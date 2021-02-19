namespace DocFx.Plugins.Kroki.Renderers
{
  public class DitaaRenderer : KrokiRenderer
  {
    public override string Name => nameof(DitaaRenderer);

    public override DiagramType DiagramType => DiagramType.Ditaa;

    public DitaaRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
