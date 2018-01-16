using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorks.UI.BarTender
{
    public interface IBartenderService
    {
        Task<string> PrintFile(string filename);
        Task<string> GetPreviewFile(string filename, int width, int height);
        string GetMessage(string message);
    }

    public class BartenderService : IBartenderService
    {
        public async Task<string> PrintFile(string filename)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9001"); ///api/Print/Print/{filename}";
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Filename", filename),
                    new KeyValuePair<string, string>("Orientation", "11"),
                    new KeyValuePair<string, string>("NumberOfLables", "12")

                });
                var result = await client.PostAsync("api/Print/SendPrint", content).ConfigureAwait(false);

                var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                return resultContent;

            }
        }

        public async Task<string> GetPreviewFile(string filename, int width, int height)
        {
            var url =
                $@"http://localhost:9001/api/Print/GetPreview/{width}/{height}/{filename}";
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);

                var r = response.Content.ReadAsStringAsync();

                return r.Result;
            }
        }

        public string GetMessage(string message)
        {
            dynamic d = JsonConvert.DeserializeObject<JObject>(message);
            return d.Message;
        }

    }
}
