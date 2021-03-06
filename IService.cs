﻿using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace SiteServer.Plugin
{
    public interface IService
    {
        // 
        // Action<object, FileSystemEventArgs> FileSystemChanged { get; }

        event EventHandler<ContentEventArgs> ContentAddCompleted;

        event EventHandler<ContentEventArgs> ContentDeleteCompleted;

        event EventHandler<ContentTranslateEventArgs> ContentTranslateCompleted;

        event EventHandler<ContentFormSubmitEventArgs> ContentFormSubmit;

        event ContentFormLoadEventHandler ContentFormLoad;

        //IService AddContentForm(string attributeName, Func<int, int, IAttributes, string> customized);

        event EventHandler<ParseEventArgs> BeforeStlParse;

        event EventHandler<ParseEventArgs> AfterStlParse;

        IService AddPluginMenu(Menu menu);

        IService AddSiteMenu(Func<int, Menu> siteMenuFunc);

        IService AddContentModel(string tableName, List<TableColumn> tableColumns);

        IService AddDatabaseTable(string tableName, List<TableColumn> tableColumns);

        IService AddContentLinks(List<HyperLink> links);

        IService AddStlElementParser(string elementName, Func<IParseContext, string> parse);

        event ApiEventHandler ApiGet;

        event ApiEventHandler ApiPost;

        event ApiEventHandler ApiPut;

        event ApiEventHandler ApiDelete;

        //IService AddJsonGet(Func<IRequest, object> jsonGet);

        //IService AddJsonGet(Func<IRequest, string, object> jsonGetWithName);

        //IService AddJsonGet(Func<IRequest, string, string, object> jsonGetWithNameAndId);

        //IService AddJsonPost(Func<IRequest, object> jsonPost);

        //IService AddJsonPost(Func<IRequest, string, object> jsonPostWithName);

        //IService AddJsonPost(Func<IRequest, string, string, object> jsonPostWithNameAndId);

        //IService AddJsonPut(Func<IRequest, object> jsonPut);

        //IService AddJsonPut(Func<IRequest, string, object> jsonPutWithName);

        //IService AddJsonPut(Func<IRequest, string, string, object> jsonPutWithNameAndId);

        //IService AddJsonDelete(Func<IRequest, object> jsonDelete);

        //IService AddJsonDelete(Func<IRequest, string, object> jsonDeleteWithName);

        //IService AddJsonDelete(Func<IRequest, string, string, object> jsonDeleteWithNameAndId);

        //IService AddHttpGet(Func<IRequest, HttpResponseMessage> httpGet);

        //IService AddHttpGet(Func<IRequest, string, HttpResponseMessage> httpGetWithName);

        //IService AddHttpGet(Func<IRequest, string, string, HttpResponseMessage> httpGetWithNameAndId);

        //IService AddHttpPost(Func<IRequest, HttpResponseMessage> httpPost);

        //IService AddHttpPost(Func<IRequest, string, HttpResponseMessage> httpPostWithName);

        //IService AddHttpPost(Func<IRequest, string, string, HttpResponseMessage> httpPostWithNameAndId);

        //IService AddHttpPut(Func<IRequest, HttpResponseMessage> httpPut);

        //IService AddHttpPut(Func<IRequest, string, HttpResponseMessage> httpPutWithName);

        //IService AddHttpPut(Func<IRequest, string, string, HttpResponseMessage> httpPutWithNameAndId);

        //IService AddHttpDelete(Func<IRequest, HttpResponseMessage> httpDelete);

        //IService AddHttpDelete(Func<IRequest, string, HttpResponseMessage> httpDeleteWithName);

        //IService AddHttpDelete(Func<IRequest, string, string, HttpResponseMessage> httpDeleteWithNameAndId);
    }
}
