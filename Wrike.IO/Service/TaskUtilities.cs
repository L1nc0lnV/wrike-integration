using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Wrike.IO.Model;
using System.IO;
using System.Web;

namespace Wrike.IO.Service
{
    public class TaskUtilities
    {
        
        static string keyPath = @"C:\secrets\key.txt";

        async public static Task<string> CreateTaskAsync(string title)
        {
            CreateWrikeTask wrikeTask = new CreateWrikeTask();
            
            using (HttpClient client = new HttpClient())
            {
                var builder = new UriBuilder("https://www.wrike.com/api/v4/folders/IEACX73EI4M7F4VV/tasks");
                var query = HttpUtility.ParseQueryString(builder.Query);
                string key = KeyUtilities.GetKey(keyPath);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + key);
                query["title"] = title;
                builder.Query = query.ToString();
                string url = builder.ToString();

                using (HttpResponseMessage resp = await client.PostAsync(url, new StringContent("")))
                {
                    return await resp.Content.ReadAsStringAsync();
                }    
            }
        }
    }
}
