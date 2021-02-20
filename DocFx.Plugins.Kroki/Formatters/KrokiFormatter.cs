using Microsoft.DocAsCode.MarkdownLite;
using System.Text;

namespace DocFx.Plugins.Kroki.Formatters
{
  public abstract class KrokiFormatter
  {
    private readonly Options _options;
    private readonly DiagramType _diagramType;

    protected abstract string OutputFormat
    {
      get;
    }

    public KrokiFormatter(Options options, DiagramType diagramType)
    {
      _options = options;
      _diagramType = diagramType;
    }

    public virtual StringBuffer FormatDiagramData(byte[] data)
    {
      return string.Format(OutputFormat, _options.LangPrefix, _diagramType, Encoding.UTF8.GetString(data));
    }
  }
}
