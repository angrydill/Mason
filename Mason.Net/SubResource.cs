﻿using Newtonsoft.Json;
using System.Collections.Generic;


namespace Mason.Net
{
  public class SubResource : DynamicDictionary
  {
    [JsonProperty("mason:links")]
    public List<Link> Links { get; set; }

    [JsonProperty("mason:link-templates")]
    public List<LinkTemplate> LinkTemplates { get; set; }


    public void AddLink(Link l)
    {
      if (Links == null)
        Links = new List<Link>();
      Links.Add(l);
    }


    public void AddLinkTemplate(LinkTemplate t)
    {
      if (LinkTemplates == null)
        LinkTemplates = new List<LinkTemplate>();
      LinkTemplates.Add(t);
    }
  }
}
