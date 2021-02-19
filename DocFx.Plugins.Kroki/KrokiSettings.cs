using System;
using System.Collections.Generic;

namespace DocFx.Plugins.Kroki
{
  public class KrokiSettings
  {
    public OutputFormat OutputFormat
    {
      get;
    }

    public Uri ServiceUrl
    {
      get;
    }

    public KrokiSettings(IReadOnlyDictionary<string, object> parameters)
    {
      OutputFormat = parameters.GetOutputFormat(OutputFormat.SVG);
      ServiceUrl = parameters.GetServiceUrl();
    }
  }
}
