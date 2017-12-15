using Newtonsoft.Json;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Data
{
    public class CustomerDAO
    {
        public void InsertCustomer(Customer customer)
        {

            //null list of customer
            List<Customer> customerList = new List<Customer>();

            //Add customer to list
            customerList.Add(customer);
            //Assign list to variable
            var payload = customerList;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-20.australiaeast.logic.azure.com:443/workflows/b935a6b28ab74ccba89bfaaa5074a7e8/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=JVn6zCljG2G69hgBuZHgRXZYLSsZJSOZByOZAkY-Xyk"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();
                    
                    //JsonConvert.DeserializeObject<string>(response);
                    // TODO return code
                }
               
            }

        }

        public void UpdateCustomer(Customer customer)
        {
            //null list of customer
            List<Customer> customerList = new List<Customer>();
            //Add customer to list
            customerList.Add(customer);
            //Assign list to variable
            var payload = customerList;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(payload);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-28.australiaeast.logic.azure.com:443/workflows/5265e49f7196491e8d336d73284e72d9/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=fy5R67NgJ3qkW4BVEnLPVcNkxUBhOoU1MWkNofbQzeM"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();

                    //JsonConvert.DeserializeObject<string>(response);
                    // TODO return code
                }

            }
        }

        public void DeleteCustomer(Customer customer)
        {
            //null list of customer
            List<Customer> customerList = new List<Customer>();
            //Add customer to list
            customerList.Add(customer);
            //Assign list to variable
            var payload = customerList;
            //Serialise payload to JSON string and assign to stringpayload
            var stringPayload = JsonConvert.SerializeObject(customer);
            //Assign stringpayload to http content
            var httpContent = new StringContent(stringPayload, Encoding.ASCII, "application/json");
            using (var httpClient = new HttpClient())
            {
                //post data
                var response = httpClient.PostAsync(new Uri("https://prod-20.australiaeast.logic.azure.com:443/workflows/a52df28037de479a8b37d840f38b0c93/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=YfbB8qwKUTDCRXFGIMAqjan8woGLDLSmM5tkdAS-_1c"), httpContent);
                if (response.Result != null)
                {
                    var code = response.Result.StatusCode.ToString();

                    //JsonConvert.DeserializeObject<string>(response);
                    // TODO return code
                }

            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                //call the azure logic app
                var response = httpClient.GetStringAsync(new Uri("https://prod-26.australiaeast.logic.azure.com:443/workflows/3ef342e474154e67a7bce883809a580d/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=K_Lk63X-JkLaIv429GoQtMAyQnVOZVYlBZtnEzPpPL0")).Result;
                // create a list of recyclers from returned data
                var result = JsonConvert.DeserializeObject<List<Customer>>(response);
                return result;

            }
        }

        public DataTable GetAllCustomersDT()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri("https://prod-05.australiaeast.logic.azure.com:443/workflows/f3b1df6e84824fdb8757075d859194a0/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=qM0lBis78fuZLY8Ky3p7s_D9KOWOXdRqaVLitEimaQ4")).Result;
                var result = JsonConvert.DeserializeObject<DataTable>(response);
                return result;
            }
        }
    }
}
