using Microsoft.DocAsCode.Dfm;
using Microsoft.DocAsCode.MarkdownLite;
using System;

namespace DocFx.Plugins.Kroki
{
  public abstract class KrokiRenderer : DfmCustomizedRendererPartBase<IMarkdownRenderer, MarkdownCodeBlockToken, MarkdownBlockContext>
  {
    protected readonly KrokiSettings _settings;

    public abstract DiagramType DiagramType
    {
      get;
    }

    public Uri RequestUrl
      => new Uri(_settings.ServiceUrl, DiagramType.ToString().ToLower());

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
      var formatter = new SvgFormatter(renderer.Options, DiagramType);
      var client = new KrokiClient(RequestUrl);
      var byteData = client.Get(token.Code, _settings.OutputFormat).Result;
      return formatter.FormatOutput(byteData);
    }
  }
}
