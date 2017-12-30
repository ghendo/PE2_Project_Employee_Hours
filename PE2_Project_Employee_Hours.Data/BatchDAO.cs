using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data;
using System.Net.Http.Formatting;


namespace PE2_Project_Employee_Hours.Data
{
    public class BatchDAO
    {
        private readonly HttpClient httpClient = new HttpClient();

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

        public void UpdateBatch(Batch batch)
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
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-24.australiaeast.logic.azure.com:443/workflows/5d677806d36342b1991dc7a5fa40b1e1/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=p3ILHGrkolf6I2eGvhV-aJjGh_n7K8RoGBLv6QsPz5g"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();

                    //JsonConvert.DeserializeObject<string>(response);
                   
                }

            }

        }


        public void DeleteBatch(Batch batch)
        {

            //Assign batch to variable
            var payload = batch;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);

            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-13.australiaeast.logic.azure.com:443/workflows/c10c351bf0c84ff78ea4ac8cfe77681a/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=CzBBQrlH2Z0i7n2MhomJ9sdiu0-uMv6uzk-ovg6wR2k"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();
                }

            }

        }

        public async Task<DataTable> GetAllBatchesDtASYNC()
        {

            {
                var response = await GetAllBatchesData();
                var result = JsonConvert.DeserializeObject<DataTable>(response);
                return result;
            }

        }
        
        private async Task<String> GetAllBatchesData()
        {
            using (httpClient)
            {
                var response =  await httpClient.GetStringAsync(new Uri("https://prod-30.australiaeast.logic.azure.com:443/workflows/cefc1af60b134254a96cd3bc606c15bd/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=PLExap2RD5pYLYy86dLrriztRRvaMjQYDJu4Ap4ExMA"));
                return response;
            }
            
        }

        public async Task<DataTable> FindBatchesDtASYNC(String findString)
        {
            using (httpClient)
            {
                var response = await FindBatchesData(findString);
                var result = JsonConvert.DeserializeObject<DataTable>(response);
                return result;
            }

        }

        private async Task<String> FindBatchesData(String findString)
        {

            string url = "https://prod-07.australiaeast.logic.azure.com:443/workflows/47adbf1b810b47778f873abbaebc5920/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=dbhw4WAz1AP68_WtsWwOpLTx1S6tsl2_1GOzTO1dlB4";
            url += "?find=" + findString;
            var response = await httpClient.GetStringAsync(new Uri(url));
            return response;
        }

    }
}
