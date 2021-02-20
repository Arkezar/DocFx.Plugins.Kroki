using System;
using System.Collections.Generic;

namespace DocFx.Plugins.Kroki
{
  public class KrokiSettings
  {
    private const OutputFormat _defaultOutputFormat = OutputFormat.SVG;
    private const string _defaultServiceUrl = "https://kroki.io/";

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
      OutputFormat = parameters.GetOutputFormatOrDefault(_defaultOutputFormat);
      ServiceUrl = parameters.GetServiceUrlOrDefault(_defaultServiceUrl);
    }
  }
}
