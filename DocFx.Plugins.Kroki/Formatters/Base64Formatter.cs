using Microsoft.DocAsCode.MarkdownLite;

namespace DocFx.Plugins.Kroki.Formatters
{
  public class Base64Formatter : KrokiFormatter
  {
    protected override string OutputFormat
      => "<img class='{0}{1}' src='{2}'/>";

    public Base64Formatter(Options options, DiagramType diagramType) : base(options, diagramType)
    { }
  }
}
