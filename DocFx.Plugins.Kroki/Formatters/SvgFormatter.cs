using Microsoft.DocAsCode.MarkdownLite;
using System.Text;

namespace DocFx.Plugins.Kroki
{
  public class SvgFormatter
  {
    private const string _outputFormat = "<div class=\"{0}{1}\">{2}</div>";

    private readonly Options _options;
    private readonly DiagramType _diagramType;

    public SvgFormatter(Options options, DiagramType diagramType)
    {
      _options = options;
      _diagramType = diagramType;
    }

    public StringBuffer FormatOutput(byte[] data)
    {
      string svg = Encoding.UTF8.GetString(data);

      return string.Format(_outputFormat, _options.LangPrefix, _diagramType, svg);
    }
  }
}
