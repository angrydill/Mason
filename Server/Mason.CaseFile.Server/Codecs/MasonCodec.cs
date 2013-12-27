﻿using Newtonsoft.Json;
using OpenRasta.Codecs;
using OpenRasta.Web;
using System.IO;


namespace Mason.CaseFile.Server.Codecs
{
  [MediaType("application/vnd.mason;q=0.9", "ms")]
  [MediaType("application/json;q=1", "json")]
  public abstract class MasonCodec<T> : IMediaTypeWriter
  {
    public object Configuration { get; set; }


    public void WriteTo(object resource, IHttpEntity response, string[] parameters)
    {
      if (resource == null)
        return;

      Mason.Net.Resource representation = ConvertToMason((T)resource);

      JsonSerializer serializer = new JsonSerializer();
      serializer.NullValueHandling = NullValueHandling.Ignore;
      using (StreamWriter sw = new StreamWriter(response.Stream))
      using (JsonWriter jw = new JsonTextWriter(sw))
      {
        serializer.Serialize(jw, representation);
      }
    }


    protected abstract Mason.Net.Resource ConvertToMason(T resource);
  }
}
