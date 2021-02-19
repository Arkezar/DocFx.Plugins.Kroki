namespace DocFx.Plugins.Kroki.Renderers
{
  public class ActDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(ActDiagRenderer);

    public override DiagramType DiagramType => DiagramType.ActDiag;

    public ActDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
