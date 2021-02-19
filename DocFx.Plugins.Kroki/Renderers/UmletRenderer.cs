namespace DocFx.Plugins.Kroki.Renderers
{
  public class UmletRenderer : KrokiRenderer
  {
    public override string Name => nameof(UmletRenderer);

    public override DiagramType DiagramType => DiagramType.UMlet;

    public UmletRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
