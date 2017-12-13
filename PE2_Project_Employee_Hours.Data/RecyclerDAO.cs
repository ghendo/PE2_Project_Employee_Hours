using Newtonsoft.Json;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Data
{
    public class RecyclerDAO
    {
        public string InsertRecycler(Recycler recycler)
        {

            //null list of states
            List<Recycler> recyclerList = new List<Recycler>();

            //Add batch to list
            recyclerList.Add(recycler);
            //Assign list to variable
            var payload = recyclerList;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-26.australiaeast.logic.azure.com:443/workflows/9a78e8969491460f8b582ee172df73f4/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=WwFo-9UUIBktUKbV6mPdaSoqHqHTiQ4SBPS1Jfzftfo"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();
                    return code;
                    //JsonConvert.DeserializeObject<string>(response);
                    // From here on you could deserialize the ResponseContent back again to a concrete C# type using Json.Net
                }
                return "999";
            }

        }

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
    }
}
