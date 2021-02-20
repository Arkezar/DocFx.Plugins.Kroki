using Microsoft.DocAsCode.MarkdownLite;

namespace DocFx.Plugins.Kroki.Formatters
{
  public class SvgFormatter : KrokiFormatter
  {
    protected override string OutputFormat
      => "<div class='{0}{1}'>{2}</div>";

    public SvgFormatter(Options options, DiagramType diagramType) : base(options, diagramType)
    { }
  }
}
