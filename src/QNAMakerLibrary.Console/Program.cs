using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using QNAMakerClient.v4;
using QNAMakerClient.v4.Enumerator;
using QNAMakerClient.v4.Model;
using QNAMakerLibrary.v4;

namespace QNAClient.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var subscriptionKey = "{subscriptionKey}";
            var kbId = Guid.Parse("{kbId}");
            var operationId = Guid.Parse("{operationId}");
            var host = "https://{host}.azurewebsites.net/qnamaker";
            var endpointKey = Guid.Parse("{endpointKey}");


            //using (var client = new QnAMakerClient(subscriptionKey))
            //{
            //    //CreateKnowledgebase(client).Wait();
            //    //DeleteKnowledgebase(client, kbId).Wait();
            //    //DownloadKnowledgebase(client, kbId).Wait();
            //    //DownloadAlterations(client).Wait();
            //    //GetEndpointKeys(client).Wait();
            //    //GetEndpointSettings(client).Wait();
            //    //GetKnowledgebaseDetails(client, kbId).Wait();
            //    //GetKnowledgebaseForUser(client).Wait();
            //    //GetOperationDetails(client, operationId).Wait();
            //    //PublishKnowledgebase(client, kbId).Wait();
            //    //RefreshEndpointKeys(client, "PrimaryEndpointKey").Wait();
            //    //UpdateEndpointSettings(client).Wait();
            //    //ReplaceAlterations(client).Wait();
            //    //ReplaceKnowledgebase(client, kbId).Wait();
            //    //ReplaceKnowledgebase(client, kbId).Wait();
            //    //UpdateKnowledgebaseAdd(client, kbId).Wait();
            //    //UpdateKnowledgebaseDeletebySource(client, kbId).Wait();
            //    //UpdateKnowledgebaseDeleteById(client, kbId).Wait();
            //    //UpdateKnowledgebaseUpdate(client, kbId).Wait();
            //    MakeAQuestion(client,host,endpointKey, kbId).Wait();
            //}

           using (var client = new QnAMaker(new QnAMakerEndpoint()
            {
                KnowledgeBaseId = kbId,
                Enviroment = Enviroment.Prod,
                Score = 0f,
                SubscriptionKey = subscriptionKey,
                Host = host,
                EndpointKey = endpointKey,
            }))
            {
                //CreateKnowledgebase(client).Wait();
                //DeleteKnowledgebase(client).Wait();
                //DownloadKnowledgebase(client).Wait();
                //DownloadAlterations(client).Wait();
                //GetEndpointKeys(client).Wait();
                //GetEndpointSettings(client).Wait();
                //GetKnowledgebaseDetails(client).Wait();
                //GetKnowledgebaseForUser(client).Wait();
                //GetOperationDetails(client, operationId).Wait();
                //PublishKnowledgebase(client).Wait();
                //RefreshEndpointKeys(client, "PrimaryEndpointKey").Wait();
                //UpdateEndpointSettings(client).Wait();
                //ReplaceAlterations(client).Wait();
                //ReplaceKnowledgebase(client).Wait();
                //ReplaceKnowledgebase(client).Wait();
                UpdateKnowledgebaseAdd(client).Wait();
                //UpdateKnowledgebaseDeletebySource(client).Wait();
                //UpdateKnowledgebaseDeleteById(client).Wait();
                //UpdateKnowledgebaseUpdate(client).Wait();
                //MakeAQuestion(client).Wait();
            }

            System.Console.WriteLine("fim");
            System.Console.ReadLine();
        }

        #region FirstClient

        //#region Create Knowledgebase

        //static async Task CreateKnowledgebase(QnAMakerClient client)
        //{
        //    var ckb = new KnowledgebaseCreate
        //    {
        //        name = "teste - " + DateTime.Now,
        //        qnaList = new List<QnaList>()
        //        {
        //            new QnaList()
        //            {
        //                answer = "Resposta 01",
        //                questions = new List<string>()
        //                {
        //                    "Pergunta 01",
        //                    "Pergunta 02",
        //                },
        //                metadata = new List<Metadata>()
        //                {
        //                    new Metadata()
        //                    {
        //                        name = "parametro01",
        //                        value = "000001"
        //                    },
        //                    new Metadata()
        //                    {
        //                        name = "parametro02",
        //                        value = "000002"
        //                    }
        //                },
        //                id = 0001,
        //                source = "Editorial",
        //            },
        //            new QnaList()
        //            {
        //                answer = "Resposta 02",
        //                questions = new List<string>()
        //                {
        //                    "Pergunta 03",
        //                    "Pergunta 04",
        //                },
        //                metadata = new List<Metadata>()
        //                {
        //                    new Metadata()
        //                    {
        //                        name = "parametro03",
        //                        value = "000003"
        //                    },
        //                    new Metadata()
        //                    {
        //                        name = "parametro04",
        //                        value = "000004"
        //                    }
        //                },
        //                id = 0002,
        //                source = "Editorial",
        //            }
        //        },

        //        urls = new List<string>()
        //        {
        //            "https://docs.microsoft.com/en-in/azure/cognitive-services/qnamaker/faqs",
        //            "https://docs.microsoft.com/en-us/bot-framework/resources-bot-framework-faq"
        //        },

        //        files = new List<File>()
        //        {
        //            new File()
        //            {
        //                fileName = "SurfaceManual.pdf",
        //                fileUri =
        //                    "https://download.microsoft.com/download/2/9/B/29B20383-302C-4517-A006-B0186F04BE28/surface-pro-4-user-guide-EN.pdf",
        //            }
        //        }
        //    };

        //    try
        //    {
        //        var resposta = await client.CreateKnowledgeBase(ckb);

        //        System.Console.WriteLine(resposta.operationState);
        //        System.Console.WriteLine(resposta.operationId);
        //    }
        //    catch (QnaMakerException e)
        //    {
        //        System.Console.WriteLine(e.Error.message);
        //        // throw;
        //    }
        //    catch (Exception e)
        //    {
        //        System.Console.WriteLine(e.Message);
        //        //throw;
        //    }

        //}

        //#endregion

        //#region Delete Knowledgebase

        //static async Task DeleteKnowledgebase(QnAMakerClient client, Guid kbId)
        //{
        //    await client.DeleteKnowledgeBase(kbId);

        //}
        //#endregion

        //#region Download Knowledgebase

        //static async Task DownloadKnowledgebase(QnAMakerClient client, Guid kbId)
        //{
        //    var xxx = await client.DownloadKnowledgeBase(kbId, Enviroment.Prod);

        //    foreach (var item in xxx.qnaDocuments)
        //    {
        //        System.Console.WriteLine($"{item.id} - {item.source}");
        //        System.Console.WriteLine("-------------------");
        //    }

        //}
        //#endregion

        //#region Download Alterations

        //static async Task DownloadAlterations(QnAMakerClient client)
        //{
        //    var xxx = await client.DownloadAlterations();

        //    foreach (var item in xxx.wordAlterations)
        //    {
        //        foreach (var VARIABLE in item.alterations)
        //        {
        //            System.Console.WriteLine(VARIABLE);
        //        }
        //    }

        //}
        //#endregion

        //#region Get Endpoint Keys

        //static async Task GetEndpointKeys(QnAMakerClient client)
        //{
        //    var xxx = await client.GetEndpointKeys();

        //    System.Console.WriteLine(xxx.installedVersion);
        //    System.Console.WriteLine(xxx.lastStableVersion);
        //    System.Console.WriteLine(xxx.primaryEndpointKey);
        //    System.Console.WriteLine(xxx.secondaryEndpointKey);

        //}
        //#endregion

        //#region Get Endpoint Settings

        //static async Task GetEndpointSettings(QnAMakerClient client)
        //{
        //    var xxx = await client.GetEndpointSettings();

        //    System.Console.WriteLine(xxx.activeLearning.enable);
        //}
        //#endregion

        //#region Get Knowledgebase Details

        //static async Task GetKnowledgebaseDetails(QnAMakerClient client, Guid kbId)
        //{
        //    var xxx = await client.GetKnowledgebaseDetails(kbId);

        //    System.Console.WriteLine(xxx.name);
        //    System.Console.WriteLine(xxx.userId);
        //}
        //#endregion

        //#region Get Knowledgebase for User

        //static async Task GetKnowledgebaseForUser(QnAMakerClient client)
        //{
        //    var result = await client.GetKnowledgebaseForUser();

        //    foreach (var item in result.knowledgebases)
        //    {
        //        System.Console.WriteLine(item.name);
        //        System.Console.WriteLine(item.userId);
        //    }
        //}
        //#endregion

        //#region Get Operation Details

        //static async Task GetOperationDetails(QnAMakerClient client, Guid operationId)
        //{
        //    var xxx = await client.GetOperationDetails(operationId);

        //    System.Console.WriteLine(xxx.operationState);
        //    System.Console.WriteLine(xxx.userId);
        //}
        //#endregion

        //#region Publish Knowledgebase 

        //static async Task PublishKnowledgebase(QnAMakerClient client, Guid kbId)
        //{
        //    await client.PostPublishKnowledgebase(kbId);
        //}
        //#endregion

        //#region Refresh Endpoint Keys

        //static async Task RefreshEndpointKeys(QnAMakerClient client, string keyType)
        //{
        //    var xxx = await client.RefreshEndpointKeys(keyType);

        //    System.Console.WriteLine(xxx.installedVersion);
        //    System.Console.WriteLine(xxx.lastStableVersion);
        //    System.Console.WriteLine(xxx.primaryEndpointKey);
        //    System.Console.WriteLine(xxx.secondaryEndpointKey);

        //}
        //#endregion

        //#region Replace Alterations


        //static async Task ReplaceAlterations(QnAMakerClient client)
        //{
        //    var alt = new Alterations();

        //    alt.wordAlterations.Add(new Wordalteration()
        //    {
        //        alterations = new List<string>()
        //        {
        //            "qnamaker",
        //            "qna maker",
        //            "banco de soluções"
        //        }
        //    });

        //    alt.wordAlterations.Add(new Wordalteration()
        //    {
        //        alterations = new List<string>()
        //        {
        //            "botframework",
        //            "bot framework",
        //            "bote"
        //        }
        //    });

        //    alt.wordAlterations.Add(new Wordalteration()
        //    {
        //        alterations = new List<string>()
        //        {
        //            "webchat",
        //            "web chat",
        //            "chate"
        //        }
        //    });

        //    await client.ReplaceAlterations(alt);
        //}
        //#endregion

        //#region Replace Knowledgebase


        //static async Task ReplaceKnowledgebase(QnAMakerClient client, Guid kbId)
        //{
        //    var kbreplace = new KnowledgebaseReplace
        //    {
        //        qnaList = (await client.DownloadKnowledgeBase(kbId, Enviroment.Prod)).qnaDocuments
        //    };

        //    foreach (var item in kbreplace.qnaList)
        //    {
        //        item.metadata = new List<Metadata>()
        //        {
        //            new Metadata()
        //            {
        //                name = "origem",
        //                value = "xpto"
        //            }
        //        };
        //    }

        //    await client.ReplaceKnowledgebase(kbId, kbreplace);

        //}
        //#endregion

        //#region Update Endpoint Settings

        //static async Task UpdateEndpointSettings(QnAMakerClient client)
        //{
        //    await client.UpdateEndpointSettings(new EndpointSettings { activeLearning = { enable = "true" } });
        //}
        //#endregion

        //#region Update Knowledgebase

        //static async Task UpdateKnowledgebaseAdd(QnAMakerClient client, Guid kbId)
        //{
        //    var kbUpdate = new KnowledgebaseUpdate();
        //    kbUpdate.add = new Add();
        //    kbUpdate.add.qnaList.Add(new QnaList()
        //    {
        //        questions = new List<string>()
        //        {
        //            "teste pergunta "+ GetDateTimeIdentify(),
        //        },
        //        answer = "resposta pergutna " + GetDateTimeIdentify(),
        //        //id = 123,
        //        metadata = new List<Metadata>()
        //        {
        //            new Metadata()
        //            {
        //                name = "xxxx",
        //                value = "xxx " + GetDateTimeIdentify(),
        //            }
        //        },
        //        source = "Editorial"
        //    });

        //    var retorno = await client.UpdateKnowledgebase(kbId, kbUpdate);

        //    System.Console.WriteLine(retorno.operationId);
        //}

        //static async Task UpdateKnowledgebaseDeletebySource(QnAMakerClient client, Guid kbId)
        //{
        //    var kbUpdate = new KnowledgebaseUpdate
        //    {
        //        delete = new Delete
        //        {
        //            sources = new List<string>()
        //        {
        //            "KB"
        //        }
        //        }
        //    };

        //    var retorno = await client.UpdateKnowledgebase(kbId, kbUpdate);

        //    System.Console.WriteLine(retorno.operationId);
        //}

        //static async Task UpdateKnowledgebaseDeleteById(QnAMakerClient client, Guid kbId)
        //{
        //    var kbUpdate = new KnowledgebaseUpdate
        //    {
        //        delete = new Delete
        //        {
        //            ids = new List<int>()
        //        {
        //            142
        //        }
        //        }
        //    };

        //    var retorno = await client.UpdateKnowledgebase(kbId, kbUpdate);

        //    System.Console.WriteLine(retorno.operationId);
        //}

        //static async Task UpdateKnowledgebaseUpdate(QnAMakerClient client, Guid kbId)
        //{
        //    var kbUpdate = new KnowledgebaseUpdate();

        //    kbUpdate.update.qnaList = new List<QnaListUpdate>();
        //    kbUpdate.update.qnaList.Add(new QnaListUpdate()
        //    {
        //        id = 142,
        //        source = "Editorial",
        //        answer = "resposta atualizada",
        //        questions = new QuestionsUpdate()
        //        {
        //            add = new List<string>()
        //                    {
        //                        "nova pergunta xxxx?"
        //                }
        //        },
        //        metadata = new MetadataUpdate()
        //        {
        //            add = new List<Metadata>()
        //                {
        //                    new Metadata()
        //                    {
        //                        name = "novomd",
        //                        value = "xpto " + GetDateTimeIdentify(),
        //                    }
        //                }
        //        }
        //    }
        //     );

        //    var retorno = await client.UpdateKnowledgebase(kbId, kbUpdate);

        //    System.Console.WriteLine(retorno.operationId);
        //}
        //#endregion

        //#region Make a Question

        //static async Task MakeAQuestion(QnAMakerClient client, string host, Guid enpointKey, Guid kbId)
        //{
        //    var q = new Question()
        //    {
        //        question = "como carregar um celular",
        //        top = 8,
        //        strictFilters = new List<Metadata>()
        //        {
        //            new Metadata()
        //            {
        //                name = "parametro02",
        //                value = "000002"
        //            }
        //        },
        //        //Score = 9.5f,
        //        userId = "xpto"
        //    };

        //    var xxx = await client.MakeAQuestion(host, enpointKey, kbId, q);

        //    foreach (var answerItem in xxx.answers)
        //    {
        //        System.Console.WriteLine($"Id - {answerItem.id}");
        //        System.Console.WriteLine($"Answer - {answerItem.answer}");
        //        System.Console.WriteLine($"Score - {answerItem.score}");
        //        System.Console.WriteLine($"Source - {answerItem.source}");

        //        foreach (var metadata in answerItem.metadata)
        //        {
        //            System.Console.WriteLine($"Metadata : {metadata.name} - {metadata.value}");
        //        }

        //        foreach (var question in answerItem.questions)
        //        {
        //            System.Console.WriteLine($"Question : {question}");
        //        }

        //        System.Console.WriteLine("-------------------");
        //    }

        //}
        //#endregion

        #endregion

        #region Create Knowledgebase

        static async Task CreateKnowledgebase(QnAMaker client)
        {
            var ckb = new KnowledgebaseCreate
            {
                name = "teste - " + DateTime.Now,
                qnaList = new List<QnaList>()
                {
                    new QnaList()
                    {
                        answer = "Resposta 01",
                        questions = new List<string>()
                        {
                            "Pergunta 01",
                            "Pergunta 02",
                        },
                        metadata = new List<Metadata>()
                        {
                            new Metadata()
                            {
                                name = "parametro01",
                                value = "000001"
                            },
                            new Metadata()
                            {
                                name = "parametro02",
                                value = "000002"
                            }
                        },
                        id = 0001,
                        source = "Editorial",
                    },
                    new QnaList()
                    {
                        answer = "Resposta 02",
                        questions = new List<string>()
                        {
                            "Pergunta 03",
                            "Pergunta 04",
                        },
                        metadata = new List<Metadata>()
                        {
                            new Metadata()
                            {
                                name = "parametro03",
                                value = "000003"
                            },
                            new Metadata()
                            {
                                name = "parametro04",
                                value = "000004"
                            }
                        },
                        id = 0002,
                        source = "Editorial",
                    }
                },

                urls = new List<string>()
                {
                    "https://docs.microsoft.com/en-in/azure/cognitive-services/qnamaker/faqs",
                    "https://docs.microsoft.com/en-us/bot-framework/resources-bot-framework-faq"
                },

                files = new List<File>()
                {
                    new File()
                    {
                        fileName = "SurfaceManual.pdf",
                        fileUri =
                            "https://download.microsoft.com/download/2/9/B/29B20383-302C-4517-A006-B0186F04BE28/surface-pro-4-user-guide-EN.pdf",
                    }
                }
            };

            try
            {
                var resposta = await client.CreateKnowledgeBase(ckb);

                System.Console.WriteLine(resposta.operationState);
                System.Console.WriteLine(resposta.operationId);
            }
            catch (QnaMakerException e)
            {
                System.Console.WriteLine(e.Error.message);
                // throw;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                //throw;
            }

        }

        #endregion

        #region Delete Knowledgebase

        static async Task DeleteKnowledgebase(QnAMaker client)
        {
            await client.DeleteKnowledgeBase();

        }
        #endregion

        #region Download Knowledgebase

        static async Task DownloadKnowledgebase(QnAMaker client)
        {
            var xxx = await client.DownloadKnowledgeBase();

            foreach (var item in xxx.qnaDocuments)
            {
                System.Console.WriteLine($"{item.id} - {item.source}");
                System.Console.WriteLine("-------------------");
            }

        }
        #endregion

        #region Download Alterations

        static async Task DownloadAlterations(QnAMaker client)
        {
            var xxx = await client.DownloadAlterations();

            foreach (var item in xxx.wordAlterations)
            {
                foreach (var VARIABLE in item.alterations)
                {
                    System.Console.WriteLine(VARIABLE);
                }
            }

        }
        #endregion

        #region Get Endpoint Keys

        static async Task GetEndpointKeys(QnAMaker client)
        {
            var xxx = await client.GetEndpointKeys();

            System.Console.WriteLine(xxx.installedVersion);
            System.Console.WriteLine(xxx.lastStableVersion);
            System.Console.WriteLine(xxx.primaryEndpointKey);
            System.Console.WriteLine(xxx.secondaryEndpointKey);

        }
        #endregion

        #region Get Endpoint Settings

        static async Task GetEndpointSettings(QnAMaker client)
        {
            var xxx = await client.GetEndpointSettings();

            System.Console.WriteLine(xxx.activeLearning.enable);
        }
        #endregion

        #region Get Knowledgebase Details

        static async Task GetKnowledgebaseDetails(QnAMaker client)
        {
            var xxx = await client.GetKnowledgebaseDetails();

            System.Console.WriteLine(xxx.name);
            System.Console.WriteLine(xxx.userId);
        }
        #endregion

        #region Get Knowledgebase for User

        static async Task GetKnowledgebaseForUser(QnAMaker client)
        {
            var result = await client.GetKnowledgebaseForUser();

            foreach (var item in result.knowledgebases)
            {
                System.Console.WriteLine(item.name);
                System.Console.WriteLine(item.userId);
            }
        }
        #endregion

        #region Get Operation Details

        static async Task GetOperationDetails(QnAMaker client, Guid operationId)
        {
            var xxx = await client.GetOperationDetails(operationId);

            System.Console.WriteLine(xxx.operationState);
            System.Console.WriteLine(xxx.userId);
        }
        #endregion

        #region Publish Knowledgebase 

        static async Task PublishKnowledgebase(QnAMaker client)
        {
            await client.PostPublishKnowledgebase();
        }
        #endregion

        #region Refresh Endpoint Keys

        static async Task RefreshEndpointKeys(QnAMaker client, string keyType)
        {
            var xxx = await client.RefreshEndpointKeys(keyType);

            System.Console.WriteLine(xxx.installedVersion);
            System.Console.WriteLine(xxx.lastStableVersion);
            System.Console.WriteLine(xxx.primaryEndpointKey);
            System.Console.WriteLine(xxx.secondaryEndpointKey);

        }
        #endregion

        #region Replace Alterations


        static async Task ReplaceAlterations(QnAMaker client)
        {
            var alt = new Alterations();

            alt.wordAlterations.Add(new Wordalteration()
            {
                alterations = new List<string>()
                {
                    "qnamaker",
                    "qna maker",
                    "banco de soluções"
                }
            });

            alt.wordAlterations.Add(new Wordalteration()
            {
                alterations = new List<string>()
                {
                    "botframework",
                    "bot framework",
                    "bote"
                }
            });

            alt.wordAlterations.Add(new Wordalteration()
            {
                alterations = new List<string>()
                {
                    "webchat",
                    "web chat",
                    "chate"
                }
            });

            await client.ReplaceAlterations(alt);
        }
        #endregion

        #region Replace Knowledgebase

        static async Task ReplaceKnowledgebase(QnAMaker client)
        {
            var kbreplace = new KnowledgebaseReplace
            {
                qnaList = (await client.DownloadKnowledgeBase()).qnaDocuments
            };

            foreach (var item in kbreplace.qnaList)
            {
                item.metadata = new List<Metadata>()
                {
                    new Metadata()
                    {
                        name = "origem",
                        value = "xpto"
                    }
                };
            }
            
            await client.ReplaceKnowledgebase(kbreplace);
            
        }
        #endregion

        #region Update Endpoint Settings

        static async Task UpdateEndpointSettings(QnAMaker client)
        {
            await client.UpdateEndpointSettings(new EndpointSettings { activeLearning = { enable = "true" } });
        }
        #endregion

        #region Update Knowledgebase

        static async Task UpdateKnowledgebaseAdd(QnAMaker client)
        {
            var kbUpdate = new KnowledgebaseUpdate();
            kbUpdate.add = new Add();
            kbUpdate.add.qnaList.Add(new QnaList()
            {
                questions = new List<string>()
                {
                    "teste pergunta "+ GetDateTimeIdentify(),
                },
                answer = "resposta pergutna " + GetDateTimeIdentify(),
                //id = 123,
                metadata = new List<Metadata>()
                {
                    new Metadata()
                    {
                        name = "xxxx",
                        value = "xxx " + GetDateTimeIdentify(),
                    }
                },
                source = "Editorial"
            });

            var retorno = await client.UpdateKnowledgebase(kbUpdate);

            System.Console.WriteLine(retorno.operationId);
        }

        static async Task UpdateKnowledgebaseDeletebySource(QnAMaker client)
        {
            var kbUpdate = new KnowledgebaseUpdate
            {
                delete = new Delete
                {
                    sources = new List<string>()
                {
                    "KB"
                }
                }
            };

            var retorno = await client.UpdateKnowledgebase(kbUpdate);

            System.Console.WriteLine(retorno.operationId);
        }

        static async Task UpdateKnowledgebaseDeleteById(QnAMaker client, Guid kbId)
        {
            var kbUpdate = new KnowledgebaseUpdate
            {
                delete = new Delete
                {
                    ids = new List<int>()
                {
                    142
                }
                }
            };

            var retorno = await client.UpdateKnowledgebase(kbUpdate);

            System.Console.WriteLine(retorno.operationId);
        }

        static async Task UpdateKnowledgebaseUpdate(QnAMaker client)
        {
            var kbUpdate = new KnowledgebaseUpdate();

            kbUpdate.update.qnaList = new List<QnaListUpdate>();
            kbUpdate.update.qnaList.Add(new QnaListUpdate()
                {
                    id = 142,
                    source = "Editorial",
                    answer = "resposta atualizada",
                    questions = new QuestionsUpdate()
                    {
                        add = new List<string>()
                            {
                                "nova pergunta xxxx?"
                        }
                    },
                    metadata = new MetadataUpdate()
                    {
                        add = new List<Metadata>()
                        {
                            new Metadata()
                            {
                                name = "novomd",
                                value = "xpto " + GetDateTimeIdentify(),
                            }
                        }
                    }
                }
             );

            var retorno = await client.UpdateKnowledgebase(kbUpdate);

            System.Console.WriteLine(retorno.operationId);
        }
        #endregion

        #region Make a Question

        static async Task MakeAQuestion(QnAMaker client)
        {
            var q = new Question()
            {
                question = "como carregar um celular",
                //top = 3,
                //strictFilters = new List<Metadata>()
                //{
                //    new Metadata()
                //    {
                //        name = "parametro02",
                //        value = "000002"
                //    }
                //},
                //Score = 9.5f,
                userId = "xpto"
            };

            var xxx = await client.MakeAQuestion("como carregar um celular");

            foreach (var answerItem in xxx.answers)
            {
                System.Console.WriteLine($"Id - {answerItem.id}");
                System.Console.WriteLine($"Answer - {answerItem.answer}");
                System.Console.WriteLine($"Score - {answerItem.score}");
                System.Console.WriteLine($"Source - {answerItem.source}");

                foreach (var metadata in answerItem.metadata)
                {
                    System.Console.WriteLine($"Metadata : {metadata.name} - {metadata.value}");
                }

                foreach (var question in answerItem.questions)
                {
                    System.Console.WriteLine($"Question : {question}");
                }

                System.Console.WriteLine("-------------------");
            }

        }
        #endregion

        static string GetDateTimeIdentify()
        {
            return DateTime.Now.ToString("s").Replace(":", "").Replace("-", "").Replace("T", "");
        }


    }
}
