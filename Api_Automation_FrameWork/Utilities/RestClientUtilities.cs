using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Api_Automation_FrameWork.Utilities
{
    public class RestClientUtilities
    {
        static RestClient _RestClient;
        static RestRequest _RestRequest;

        public static RestClient RestClient
        {

            get

            {
                if (_RestClient == null)
                {
                    return new RestClient("https://jsonplaceholder.typicode.com/");
                }
                else
                {
                    return _RestClient;
                }
            }
        }

      
        public static RestRequest CreateRestRequest(string resource, Method method)
        {
            if (_RestRequest == null)
            {
                return new RestRequest(resource, method);
            }
            else
            {
                return _RestRequest;
            }
        }

        public static T Post<T>(string resource, string payload)
        {
            return JsonConvert.DeserializeObject<T>
                (RestClient.Execute<T>(CreateRestRequest(resource, Method.Post).AddJsonBody(payload)
                   ).Content);
        }

        public static bool  Delete<T>(string resource,HttpStatusCode ExpectedStatusCode)
        {
          return  
            RestClient.Execute<T>
                (
                CreateRestRequest(resource, Method.Delete)
                ).StatusCode.Equals(ExpectedStatusCode);
                   
        }
        public static T Get<T>(string resource,HttpStatusCode ExpectedStatusCode)
        {
            return JsonConvert.DeserializeObject<T>( RestClient.Execute<T>
                 (
                 CreateRestRequest(resource, Method.Post)
                 ).Content);

        }
		// Change1
		//change 2








    }
}
