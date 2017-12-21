using Newtonsoft.Json;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Data;

namespace PE2_Project_Employee_Hours.Data
{
    public class RecyclerDAO
    {

        public List<Recycler> GetAllRecyclers()
        {
            using (var httpClient = new HttpClient())
            {
                //call the azure logic app
                var response = httpClient.GetStringAsync(new Uri("https://prod-26.australiaeast.logic.azure.com:443/workflows/9a78e8969491460f8b582ee172df73f4/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=WwFo-9UUIBktUKbV6mPdaSoqHqHTiQ4SBPS1Jfzftfo")).Result;
                // create a list of recyclers from returned data
                var result = JsonConvert.DeserializeObject<List<Recycler>>(response);
                return result;

            }
        }

        public async Task<List<Recycler>> GetAllRecyclersListASYNC()
        {
            var response = await GetAllRecyclersData();
            var result = JsonConvert.DeserializeObject<List<Recycler>>(response);
            return result;
        }


        public async Task<String> InsertRecyclerASYNC(Recycler recycler)
        {
            List<Recycler> recyclerList = new List<Recycler>();
            //Add recycler to list
            recyclerList.Add(recycler);
            //Assign list to variable
            var payload = recyclerList;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //perform the insert
            string result = await InsertRecyclerData(stringPayload);
            return result;

        }

        private async Task<String> InsertRecyclerData(String stringPayload)
        {
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = await httpClient.PostAsync(new Uri("https://prod-24.australiaeast.logic.azure.com:443/workflows/439c5f75f025416abfeedba657659ab4/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=FB4eZ02feq4wIaohWJ7QiHh9aNDYAmWPqHGoELysHpY"), httpContent);
                if (response != null)
                {
                    var code = response.StatusCode.ToString();
                    return code;
                }
                return "999";
            }
        }

        public async Task<DataTable> GetAllRecyclersDt()
        {
                string response = await GetAllRecyclersData();
                var result = JsonConvert.DeserializeObject<DataTable>(response);
                return result;
        }

        private async Task<String> GetAllRecyclersData()
        {
            using (var httpClient = new HttpClient())
            {
                //call the azure logic app
                var response = await httpClient.GetStringAsync(new Uri("https://prod-26.australiaeast.logic.azure.com:443/workflows/9a78e8969491460f8b582ee172df73f4/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=WwFo-9UUIBktUKbV6mPdaSoqHqHTiQ4SBPS1Jfzftfo")); 
                return response;

            }
        }
    }
}
