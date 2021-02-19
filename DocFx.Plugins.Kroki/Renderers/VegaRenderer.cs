namespace DocFx.Plugins.Kroki.Renderers
{
  public class VegaRenderer : KrokiRenderer
  {
    public override string Name => nameof(VegaRenderer);

    public override DiagramType DiagramType => DiagramType.Vega;

    public VegaRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
