using DocFx.Plugins.Kroki.Formatters;
using Microsoft.DocAsCode.Dfm;
using Microsoft.DocAsCode.MarkdownLite;
using System;

namespace DocFx.Plugins.Kroki
{
  public abstract class KrokiRenderer : DfmCustomizedRendererPartBase<IMarkdownRenderer, MarkdownCodeBlockToken, MarkdownBlockContext>
  {
    private readonly KrokiSettings _settings;

    public abstract DiagramType DiagramType
    {
      get;
    }

    public KrokiRenderer(KrokiSettings settings)
    {
      _settings = settings;
    }

    public sealed override bool Match(IMarkdownRenderer renderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
    {
      return token.Lang.Equals(DiagramType.ToString(), StringComparison.OrdinalIgnoreCase);
    }

    public sealed override StringBuffer Render(IMarkdownRenderer renderer, MarkdownCodeBlockToken token, MarkdownBlockContext context)
    {
      var formatter = GetFormatter(_settings.OutputFormat, renderer.Options, DiagramType);
      var client = new KrokiClient(_settings.ServiceUrl);
      var code = System.Net.WebUtility.HtmlDecode(token.Code);
      var byteData = client.GetDiagram(new KrokiPayload(code, DiagramType, _settings.OutputFormat)).Result;
      return formatter.FormatDiagramData(byteData);
    }

    private KrokiFormatter GetFormatter(OutputFormat outputFormat, Options options, DiagramType diagramType)
    {
      switch (outputFormat)
      {
        case OutputFormat.Base64:
          return new Base64Formatter(options, diagramType);
        case OutputFormat.JPEG:
          throw new NotImplementedException();
        case OutputFormat.PDF:
          throw new NotImplementedException();
        case OutputFormat.PNG:
          throw new NotImplementedException();
        case OutputFormat.SVG:
          return new SvgFormatter(options, diagramType);
        default:
          throw new NotSupportedException();
      }
    }
  }
}
