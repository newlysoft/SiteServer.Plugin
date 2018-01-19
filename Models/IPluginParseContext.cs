﻿using System.Collections.Generic;

namespace SiteServer.Plugin.Models
{
    public interface IPluginParseContext
    {
        Dictionary<string, string> Attributes { get; }
        string InnerXml { get; }
        int PublishmentSystemId { get; }
        int ChannelId { get; }
        int ContentId { get; }
        IContentInfo ContentInfo { get; }
        string TemplateType { get; }
        int TemplateId { get; }
    }
}