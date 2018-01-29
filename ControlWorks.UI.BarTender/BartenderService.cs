using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace ControlWorks.UI.BarTender
{
    public interface IBartenderService
    {
        Task<string> PrintFile(string filename, string orientation, string numberOfLabels, bool isTest);
        Task<string> GetPreviewFile(string filename, int width, int height);
        string GetMessage(string message);
       
    }

    public class BartenderService : IBartenderService
    {
        private readonly ILog _log = LogManager.GetLogger("FileLogger");

        public event EventHandler<PreviewFileEventArgs> PreviewFileRetrieved;
        public event EventHandler<EventArgs> PrintSent;

        private void OnPreviewFileRetrieved(string filename)
        {
            var temp = PreviewFileRetrieved;
            temp?.Invoke(this, new PreviewFileEventArgs(){Filename = filename});
        }

        public async Task<string> Cancel()
        {
            const string methodname = "api/Print/Cancel";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9001"); //api/Print/Cancel/";

                try
                {
                    var result = await client.PutAsync(methodname, null).ConfigureAwait(false);

                    var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                    return resultContent;
                }
                catch (Exception ex)
                {
                    _log.Error($"BartenderService - Operation = Cancel");
                    _log.Error($"url={client.BaseAddress}; methodname={methodname}");
                    _log.Error(ex.Message, ex);
                }

                return null;
            }
        }

        public async Task<string> Cancel(string command)
        {
            var methodname = $"api/Print/Cancel/{command}";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9001"); //api/Print/Cancel/";
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Filename", ""),
                    new KeyValuePair<string, string>("Orientation", ""),
                    new KeyValuePair<string, string>("NumberOfLables", ""),
                    new KeyValuePair<string, string>("PrintCommand", command)
                });

                try
                {
                    var result = await client.PostAsync(methodname, content).ConfigureAwait(false);

                    var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                    return resultContent;
                }
                catch (Exception ex)
                {
                    _log.Error($"BartenderService - Operation = Cancel");
                    _log.Error($"url={client.BaseAddress}; methodname={methodname}");
                    _log.Error(ex.Message, ex);
                }

                return null;
            }
        }

        private void OnPrintSent()
        {
            var temp = PrintSent;
            if (temp != null)
            {
                temp(this, new EventArgs());
            }
        }

        public async Task<string> PrintFile(string filename, string orientation, string numberOfLabels, bool isTest = false)
        {
            const string methodname = "api/Print/SendPrint";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:9001"); //api/Print/Print/{filename}";
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Filename", filename),
                    new KeyValuePair<string, string>("Orientation", orientation),
                    new KeyValuePair<string, string>("NumberOfLables", numberOfLabels),
                    new KeyValuePair<string, string>("Command", "")
                });

                try
                {
                    var result = await client.PostAsync(methodname, content).ConfigureAwait(false);

                    var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                    OnPrintSent();

                    return resultContent;
                }
                catch (Exception ex)
                {
                    _log.Error($"BartenderService - Operation = PrintFile");
                    _log.Error($"url={client.BaseAddress}; methodname={methodname}");
                    _log.Error(ex.Message, ex);
                }

                return null;
            }
        }

        public async Task<string> GetPreviewFile(string filename, int width, int height)
        {
            var url =
                $@"http://localhost:9001/api/Print/GetPreview/{width}/{height}/{filename}";
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                    var r = response.Content.ReadAsStringAsync();
                    OnPreviewFileRetrieved(GetMessage(r.Result));

                    return r.Result;
                }
                catch (Exception ex)
                {
                    _log.Error($"BartenderService - Operation = GetPreviewFile");
                    _log.Error($"url={url}");
                    _log.Error(ex.Message, ex);
                }

                return null;

            }
        }

        public string GetMessage(string message)
        {
            dynamic d = JsonConvert.DeserializeObject<JObject>(message);
            return d.Message;
        }

    }

    public class PreviewFileEventArgs : EventArgs
    {
        public string Filename { get; set; }
    }
}
