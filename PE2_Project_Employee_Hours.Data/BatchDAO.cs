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

        public async Task InsertBatchASYNC(Batch batch)
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
            var response = await BatchInsertDataASYNC(httpContent);
                if (response.IsSuccessStatusCode)
                {
                    var code = response.StatusCode;
                }
        }

        private async Task<HttpResponseMessage> BatchInsertDataASYNC(StringContent httpContent)
        {
            using (httpClient)
            {
                var response = await httpClient.PostAsync(new Uri("https://prod-25.australiaeast.logic.azure.com:443/workflows/e85d5ebce8ce4c21aa3fa29d704f6764/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=5MoZePHcm-KFEGZjqkGsRb3hwyz7GhNrYnoKZimcRLg"), httpContent);
                return response; 
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


        public async Task DeleteBatchASYNC(Batch batch)
        {

            //Assign batch to variable
            var payload = batch;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);

            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            using (httpClient)
            {
                var response = await DeleteBatchData(httpContent);
                if (response != null)
                {
                    var code = response.StatusCode.ToString();
                }

            }

        }

        private async Task<HttpResponseMessage> DeleteBatchData(StringContent httpContent)
        {
            using (httpClient)
            {
                var response = await httpClient.PostAsync(new Uri("https://prod-13.australiaeast.logic.azure.com:443/workflows/c10c351bf0c84ff78ea4ac8cfe77681a/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=CzBBQrlH2Z0i7n2MhomJ9sdiu0-uMv6uzk-ovg6wR2k"), httpContent);
                return response;
            }

        }

        public async Task<DataTable> GetAllBatchesASYNC()
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

        public async  Task<DataTable> FindBatchesDtASYNC(String findString)
        {

            
                var response =  await FindBatchesData(findString);
                var result = JsonConvert.DeserializeObject<DataTable>(response);
                var blah = result.Rows[0][0];
                Convert.ToString(blah);
                return result;
            

        }

        private async Task<String> FindBatchesData(String findString)
        {
            using (httpClient)
            {

                string urlPart1 = "https://prod-07.australiaeast.logic.azure.com:443/workflows/47adbf1b810b47778f873abbaebc5920/triggers/manual/paths/invoke";
                string urlPart2 = "?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=dbhw4WAz1AP68_WtsWwOpLTx1S6tsl2_1GOzTO1dlB4";

                string url = urlPart1 + "/find/" + findString + urlPart2;
                var response = await httpClient.GetStringAsync(new Uri(url));
                return response;
            }

        }

    }
}
