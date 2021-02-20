using System;
using System.Collections.Generic;

namespace DocFx.Plugins.Kroki
{
  public static class ParametersExtensions
  {
    public static OutputFormat GetOutputFormatOrDefault(this IReadOnlyDictionary<string, object> parameters, OutputFormat defaultValue)
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

    public static Uri GetServiceUrlOrDefault(this IReadOnlyDictionary<string, object> parameters, string defaultValue)
    {
      if (parameters.TryGetValue("kroki.serviceUrl", out object value))
      {
        return new Uri(value.ToString());
      }

      return new Uri(defaultValue);
    }
  }
}
