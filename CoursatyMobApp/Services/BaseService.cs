using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Newtonsoft.Json;

namespace CoursatyMobApp.Services
{
    public class BaseService<T> where T : class
    {

        // http://192.168.0.220:4500/api/courses
        // http://192.168.0.220:4500/api/categories

        private string baseUrl = "http://192.168.0.220:4500/api";

        public IEnumerable<T> GetRequest(string uri)
        {
            baseUrl += uri;

            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);

            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = response.Content;

                return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            }
            return default;
        }

        public string PostRequest(string uri)
        {
            return "";
        }
    }
}
