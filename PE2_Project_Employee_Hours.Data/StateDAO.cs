using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace PE2_Project_Employee_Hours.Data
{
    public class StateDAO
    {
        public string InsertState(States state)
        {

            //null list of batches
            List<States> statelist = new List<States>();

            //Add batch to list
            statelist.Add(state);
            //Assign list to variable
            var payload = statelist;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
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
    }
}
