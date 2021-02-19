namespace DocFx.Plugins.Kroki.Renderers
{
  public class SeqDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(SeqDiagRenderer);

    public override DiagramType DiagramType => DiagramType.SeqDiag;

    public SeqDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
