namespace DocFx.Plugins.Kroki.Renderers
{
  public class WaveDromRenderer : KrokiRenderer
  {
    public override string Name => nameof(WaveDromRenderer);

    public override DiagramType DiagramType => DiagramType.WaveDrom;

    public WaveDromRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
