using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using QNAMakerClient.v4;
using QNAMakerClient.v4.Model;

namespace QNAMakerLibrary.v4
{
    public class QnAMaker : IDisposable
    {
        public QnAMakerClient Client;
        public QnAMakerEndpoint Configurations { get; set; }
        

        public QnAMaker(QnAMakerEndpoint options)
        {
            Configurations = options;

            Client = new QnAMakerClient(options.SubscriptionKey);
        }

        #region Create Knowledge Base


        public async Task<OperationDetails> CreateKnowledgeBase(string name, List<QnaList> qnapairs = null,
            List<string> urls = null)
        {

            return await Client.CreateKnowledgeBase(name, qnapairs, urls);
        }


        public async Task<OperationDetails> CreateKnowledgeBase(KnowledgebaseCreate req)
        {
            return await Client.CreateKnowledgeBase(req);
        }

        #endregion

        #region Delete Knowledge Base

        public async Task DeleteKnowledgeBase()
        {
            await Client.DeleteKnowledgeBase(Configurations.KnowledgeBaseId);
        }

        #endregion

        #region Download Knowledge Base

        public async Task<KnowledgebaseDownload> DownloadKnowledgeBase()
        {
            return await Client.DownloadKnowledgeBase(Configurations.KnowledgeBaseId, Configurations.Enviroment);
        }

        #endregion

        #region Download Alterations

        public async Task<Alterations> DownloadAlterations()
        {
            return await Client.DownloadAlterations();
        }

        #endregion

        #region Get Endpoint Keys

        public async Task<EndpointKeys> GetEndpointKeys()
        {
            return await Client.GetEndpointKeys();
        }

        #endregion

        #region Get Endpoint Settings

        public async Task<EndpointSettings> GetEndpointSettings()
        {
            return await Client.GetEndpointSettings();
        }

        #endregion

        #region Get Knowledgebase Details

        public async Task<KnowledgebaseDetails> GetKnowledgebaseDetails()
        {
            return await Client.GetKnowledgebaseDetails(Configurations.KnowledgeBaseId);
        }

        #endregion

        #region Get Knowledgebase for User

        public async Task<KnowledgebaseForUser> GetKnowledgebaseForUser()
        {
            return await Client.GetKnowledgebaseForUser();
        }

        #endregion

        #region Get Operation Details

        public async Task<OperationDetails> GetOperationDetails(Guid operationId)
        {
            return await Client.GetOperationDetails(operationId);
        }

        #endregion

        #region Publish Knowledgebase

        public async Task PostPublishKnowledgebase()
        {
            await Client.PostPublishKnowledgebase(Configurations.KnowledgeBaseId);
        }

        #endregion

        #region Refresh Endpoint Keys

        public async Task<EndpointKeys> RefreshEndpointKeys(string keyType)
        {
            return await Client.RefreshEndpointKeys(keyType);
        }

        #endregion

        #region Replace Alterations 

        public async Task ReplaceAlterations(Alterations alterations)
        {
            await Client.ReplaceAlterations(alterations);
        }

        #endregion

        #region Replace Knowledgebase 

        public async Task ReplaceKnowledgebase(KnowledgebaseReplace kb)
        {
            await Client.ReplaceKnowledgebase(Configurations.KnowledgeBaseId, kb);
        }

        #endregion

        #region Update Endpoint Settings

        public async Task UpdateEndpointSettings(EndpointSettings endpointSettings)
        {
            await Client.UpdateEndpointSettings(endpointSettings);
        }

        #endregion

        #region Update Knowledgebase

        public async Task<OperationDetails> UpdateKnowledgebase(KnowledgebaseUpdate kb)
        {
            return await Client.UpdateKnowledgebase(Configurations.KnowledgeBaseId,kb);
        }

        #endregion

        #region Make a Question

        public async Task<Answers> MakeAQuestion(Question data)
        {
            return await Client.MakeAQuestion(Configurations.Host, Configurations.EndpointKey,
                Configurations.KnowledgeBaseId, data);
        }

        public async Task<Answers> MakeAQuestion(string questionText, int top = 3, List<Metadata> filters = null,
            Guid? userId = null, float score = 0)
        {
            var question = new Question
            {
                question = questionText,
                Score = Configurations.Score,
                strictFilters = Configurations.Filters,
                top = top
            };

            if (score > 0)
            {
                question.Score = score;
            }


            if (filters != null && filters.Any())
            {
                question.strictFilters.AddRange(filters);
            }


            return await Client.MakeAQuestion(Configurations.Host, Configurations.EndpointKey,
                Configurations.KnowledgeBaseId, question);
        }

        #endregion

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}
