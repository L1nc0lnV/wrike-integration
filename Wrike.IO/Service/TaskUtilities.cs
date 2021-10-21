using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Wrike.IO.Model;

namespace Wrike.IO.Service
{
    class TaskUtilities
    {
        
        static HttpClient client = new HttpClient();

        public static async Task<string> CreateTaskAsync(string title)
        {
            CreateTask task = new CreateTask();

            task.Title = title;


            string key = "";
            string path = "https://www.wrike.com/api/v4/folders/IEACX73EI4M7F4VV/tasks";

            //string json = JsonConvert.SerializeObject(task);

            //var stringContent = new StringContent(json);

            var postParams = @"?title=" + task.Title;

            //client.DefaultRequestHeaders
            //    .

            var response = await client.PostAsync(path, new StringContent(postParams))
                ;

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;

        }

        public static void GetTask()
        {

        }
    }
}
