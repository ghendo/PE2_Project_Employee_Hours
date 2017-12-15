using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace PE2_Project_Employee_Hours.Data
{
    public class StateDAO
    {
        private readonly HttpClient httpClient = new HttpClient();
        public string InsertState(State state)
        {

            //null list of states
            List<State> statelist = new List<State>();

            //Add batch to list
            statelist.Add(state);
            //Assign list to variable
            var payload = statelist;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-06.australiaeast.logic.azure.com:443/workflows/7ad0187a633c42198c1b95ef09cdcbe7/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=e04Gfo5NgEP3BI5NXfV4Pd79CPwGGbwoJUo0lYtDovM"), httpContent);
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

        public List<State> GetAllStates()
        {
            using (var httpClient = new HttpClient())
            {
                //call the azure logic app
                var response = httpClient.GetStringAsync(new Uri("https://prod-24.australiaeast.logic.azure.com:443/workflows/a67074317adb47d0bbb64623a3ce4cd9/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=n6jlQBp8RAB7ElLlSJdoy_l-zSDD6dd3FTeVOx4t-oU")).Result;
                //create a list of states from returned data
                var result = JsonConvert.DeserializeObject<List<State>>(response);
                return result;

            }


        }
            //public async Task<List<State>> GetAllStates()
            //{
            //    using(var httpClient = new HttpClient())
            //    {
            //        var response = await httpClient.GetStringAsync(new Uri("https://prod-24.australiaeast.logic.azure.com:443/workflows/a67074317adb47d0bbb64623a3ce4cd9/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=n6jlQBp8RAB7ElLlSJdoy_l-zSDD6dd3FTeVOx4t-oU")).Result;
            //        var result = JsonConvert.DeserializeObject<List<State>>(response);
            //        return result;
            //    }

            //}
        }

     
}
