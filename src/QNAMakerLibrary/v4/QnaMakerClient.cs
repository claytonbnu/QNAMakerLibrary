using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QNAClient;
using QNAMakerClient.v4.Enumerator;
using QNAMakerClient.v4.Model;

namespace QNAMakerClient.v4
{
    public class QnAMakerClient: IDisposable
    {
        private const string BaseAddress = "https://westus.api.cognitive.microsoft.com/qnamaker/v4.0/";
        //private const int MaxQnaPairs = 1000;
        //private const int MaxQnaUrls = 5;

        private readonly HttpClient _client;

        public QnAMakerClient(string subscriptionKey)
        {
            SubscriptionKey = subscriptionKey;

            _client = new HttpClient
            {
                BaseAddress = new Uri(BaseAddress)
            };
        }

        public string SubscriptionKey { get; set; }

        public void Dispose()
        {
            _client.Dispose();
        }

        #region Api Methods

        #region Create Knowledge Base

        
        public async Task<OperationDetails> CreateKnowledgeBase(string name, List<QnaList> qnapairs = null,
            List<string> urls = null)
        {
            if (qnapairs == null)
            {
                qnapairs = new List<QnaList>();
            }
            if (urls == null)
            {
                urls = new List<string>();
            }
            return await CreateKnowledgeBase(new KnowledgebaseCreate
            {
                name = name,
                qnaList = qnapairs,
                urls = urls
            });
        }

     
        public async Task<OperationDetails> CreateKnowledgeBase(KnowledgebaseCreate req)
        {
            if (string.IsNullOrEmpty(req.name))
            {
                throw new ArgumentNullException(nameof(req.name));
            }
            //if (req.qnaList != null && req.qnaList.Count > MaxQnaPairs)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(req.qnaList), $"Max {MaxQnaPairs} Q-A pairs per request");
            //}
            //if (req.urls != null && req.urls.Count > 5)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(req.urls), $"Max {MaxQnaUrls} urls per request");
            //}

            return await Send<OperationDetails>(HttpMethod.Post, "knowledgebases/create", req);
        }

        #endregion

        #region Delete Knowledge Base

        public async Task DeleteKnowledgeBase(Guid kbId)
        {
            await Send(HttpMethod.Delete, $"knowledgebases/{kbId}");
        }

        #endregion

        #region Download Knowledge Base

        public async Task<KnowledgebaseDownload> DownloadKnowledgeBase(Guid knowledgeBaseId, Enviroment enviroment)
        {
            return await Send<KnowledgebaseDownload>(HttpMethod.Get, $"knowledgebases/{knowledgeBaseId}/{enviroment}/qna");
        }

        #endregion

        #region Download Alterations

        public async Task<Alterations> DownloadAlterations()
        {
            return await Send<Alterations>(HttpMethod.Get, $"alterations");
        }

        #endregion

        #region Get Endpoint Keys

        public async Task<EndpointKeys> GetEndpointKeys()
        {
            return await Send<EndpointKeys>(HttpMethod.Get, $"endpointkeys");
        }

        #endregion

        #region Get Endpoint Settings

        public async Task<EndpointSettings> GetEndpointSettings()
        {
            return await Send<EndpointSettings>(HttpMethod.Get, $"endpointsettings");
        }

        #endregion

        #region Get Knowledgebase Details

        public async Task<KnowledgebaseDetails> GetKnowledgebaseDetails(Guid knowledgeBaseId)
        {
            return await Send<KnowledgebaseDetails>(HttpMethod.Get, $"knowledgebases/{knowledgeBaseId}");
        }

        #endregion

        #region Get Knowledgebase for User

        public async Task<KnowledgebaseForUser> GetKnowledgebaseForUser()
        {
            return await Send<KnowledgebaseForUser>(HttpMethod.Get, $"knowledgebases");
        }

        #endregion

        #region Get Operation Details

        public async Task<OperationDetails> GetOperationDetails(Guid operationId)
        {
            return await Send<OperationDetails>(HttpMethod.Get, $"operations/{operationId}");
        }

        #endregion

        #region Publish Knowledgebase

        public async Task PostPublishKnowledgebase(Guid knowledgeBaseId)
        {
            await Send(HttpMethod.Post, $"knowledgebases/{knowledgeBaseId}");
        }

        #endregion

        #region Refresh Endpoint Keys

        public async Task<EndpointKeys> RefreshEndpointKeys(string keyType)
        {
            return await Send<EndpointKeys>(new HttpMethod("Patch"), $"endpointkeys/{keyType}");
        }

        #endregion
        
        #region Replace Alterations 

        public async Task ReplaceAlterations(Alterations alterations)
        {
            await Send(HttpMethod.Put, $"alterations", alterations);
        }

        #endregion

        #region Replace Knowledgebase 

        public async Task ReplaceKnowledgebase(Guid kbId, KnowledgebaseReplace kb)
        {
            await Send(HttpMethod.Put, $"knowledgebases/{kbId}", kb);
        }

        #endregion
        
        #region Update Endpoint Settings

        public async Task UpdateEndpointSettings(EndpointSettings endpointSettings)
        {
            await Send(new HttpMethod("Patch"), $"endpointsettings", endpointSettings);
        }

        #endregion

        #region Update Knowledgebase

        public async Task<OperationDetails> UpdateKnowledgebase(Guid kbId, KnowledgebaseUpdate kb)
        {
            return await Send<OperationDetails>(new HttpMethod("Patch"), $"knowledgebases/{kbId}", kb);
        }

        #endregion

        #region Make a Question

        public async Task<Answers> MakeAQuestion(string host, Guid endpointKey, Guid kbId, Question data)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, $"{host}/knowledgebases/{kbId}/generateAnswer"))
            {
                var body = JsonConvert.SerializeObject(data);
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                request.Headers.Authorization = new AuthenticationHeaderValue("EndpointKey", endpointKey.ToString());

                using (var clientQuestion = new HttpClient())
                {
                    using (var response = await clientQuestion.SendAsync(request))
                    {
                        var list = await GetResponseContent<Answers>(response);

                        foreach (var item in list.answers.ToArray())
                        {
                            if (item.score < data.Score && Math.Abs(data.Score) > 0)
                            {
                                list.answers.Remove(item);
                            }
                        }
                        return list;
                    }
                }
            }
        }

        #endregion

        #endregion

        #region Web Methods

        private async Task<TR> Send<TR>(HttpMethod method, string url, object data = null)
        {
            using (var request = new HttpRequestMessage(method, url))
            {
                if (data != null && ( method == HttpMethod.Post || string.Equals(method.Method.ToUpper(), "PATCH")))
                {
                    var body = JsonConvert.SerializeObject(data);
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
                request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);

                using (var response = await _client.SendAsync(request))
                {
                    return await GetResponseContent<TR>(response);
                }
            }
        }
        
        private async Task<string> Send(HttpMethod method, string url, object data = null)
        {
            using (var request = new HttpRequestMessage(method, url))
            {
                if (data != null && (method == HttpMethod.Post || method == HttpMethod.Put || method == new HttpMethod("Patch")))
                {
                    var body = JsonConvert.SerializeObject(data);
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
                request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);
                using (var response = await _client.SendAsync(request))
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }

        private async Task<T> GetResponseContent<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            content = WebUtility.HtmlDecode(content);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(content);
            }

            if (!string.IsNullOrEmpty(content))
            {
                var error = JsonConvert.DeserializeObject<HttpError>(content);
                throw new QnaMakerException(response.StatusCode, error.error);
            }
            throw new QnaMakerException(response.StatusCode);
        }

        #endregion
    }
}
