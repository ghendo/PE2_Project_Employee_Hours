using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;


namespace PE2_Project_Employee_Hours.Data
{
    public class BatchDAO
    {

        public void InsertBatch(Batch batch)
        {

            //null list of batches
            List<Batch> batchlist = new List<Batch>();

            //Add batch to list
            batchlist.Add(batch);
            //Assign list to variable
            var payload = batchlist;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);

            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-25.australiaeast.logic.azure.com:443/workflows/e85d5ebce8ce4c21aa3fa29d704f6764/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=5MoZePHcm-KFEGZjqkGsRb3hwyz7GhNrYnoKZimcRLg"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();

                    //JsonConvert.DeserializeObject<string>(response);
                    // From here on you could deserialize the ResponseContent back again to a concrete C# type using Json.Net
                }

            }

        }


        public List<Batch> GetAllBatches()
        {
            List<Batch> batchlist = new List<Batch>();
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri("https://prod-30.australiaeast.logic.azure.com:443/workflows/cefc1af60b134254a96cd3bc606c15bd/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=PLExap2RD5pYLYy86dLrriztRRvaMjQYDJu4Ap4ExMA")).Result;


                JArray jsonArray = JArray.Parse(response);
                //string jsonConcat = "";
                //for (int i = 0; i < 2; i++)
                //{
                //    jsonConcat += jsonArray[i].ToString();

                //}
                

                JObject d = jsonArray[0] as JObject;// type jObject

                JValue j = d.First as JValue;


                 var result = JsonConvert.DeserializeObject<List<Batch>>(j.ToString());

                 //  var result = JsonConvert.DeserializeObject<List<Batch>>(jsonConcat.ToString());
                return result;

            }
        }

    }
}
