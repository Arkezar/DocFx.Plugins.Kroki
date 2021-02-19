namespace DocFx.Plugins.Kroki.Renderers
{
  public class SvgbobRenderer : KrokiRenderer
  {
    public override string Name => nameof(SvgbobRenderer);

    public override DiagramType DiagramType => DiagramType.Svgbob;

    public SvgbobRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
