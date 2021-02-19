namespace DocFx.Plugins.Kroki.Renderers
{
  public class RackDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(RackDiagRenderer);

    public override DiagramType DiagramType => DiagramType.RackDiag;

    public RackDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
