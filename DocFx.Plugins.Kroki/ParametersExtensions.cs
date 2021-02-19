using System;
using System.Collections.Generic;

namespace DocFx.Plugins.Kroki
{
  public static class ParametersExtensions
  {
    public static OutputFormat GetOutputFormat(this IReadOnlyDictionary<string, object> parameters, OutputFormat defaultValue)
    {
      if (parameters.TryGetValue("kroki.outputFormat", out object value))
      {
        if (Enum.TryParse(value.ToString(), true, out OutputFormat enumValue))
        {
          return enumValue;
        }
      }

      return defaultValue;
    }

    public static Uri GetServiceUrl(this IReadOnlyDictionary<string, object> parameters)
    {
      if (parameters.TryGetValue("kroki.serviceUrl", out object value))
      {
        return new Uri(value.ToString());
      }
      else
      {
        throw new ArgumentException("Required parameter is missing.", "markdownEngineProperties.kroki.serviceUrl");
      }
    }
  }
}
