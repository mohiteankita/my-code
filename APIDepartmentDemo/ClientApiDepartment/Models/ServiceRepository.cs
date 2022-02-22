using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ClientApiDept.Models
{
   
    public class ServiceRepository
    {
        public HttpClient client { get; set; }

        public ServiceRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44398/api/DeptApi");
        }

        public HttpResponseMessage GetResponse(string url)
        {
            return (client.GetAsync(url)).Result;
        }

        public HttpResponseMessage PostResponse(string url, object obj)
        {
            return (client.PostAsJsonAsync(url, obj)).Result;
        }

        public HttpResponseMessage PutResponse(string url, object obj)
        {
            return (client.PutAsJsonAsync(url, obj)).Result;
        }

        public HttpResponseMessage DeleteResponse(string url)
        {
            return (client.DeleteAsync(url)).Result;
        }

    }
}