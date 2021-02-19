namespace DocFx.Plugins.Kroki.Renderers
{
  public class NwDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(NwDiagRenderer);

    public override DiagramType DiagramType => DiagramType.NwDiag;

    public NwDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
