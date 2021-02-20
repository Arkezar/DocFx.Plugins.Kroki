using Newtonsoft.Json;

namespace DocFx.Plugins.Kroki
{
  public class KrokiPayload
  {
    [JsonProperty("diagram_source")]
    public string DiagramSource
    {
      get;
    }

    [JsonProperty("diagram_type")]
    public string DiagramType
    {
      get;
    }

    [JsonProperty("output_format")]
    public string OutputFormat
    {
      get;
    }

    public KrokiPayload(string source, DiagramType diagramType, OutputFormat outputFormat)
    {
      DiagramSource = source;
      DiagramType = diagramType.ToString().ToLower();
      OutputFormat = outputFormat.ToString().ToLower();
    }
  }
}
