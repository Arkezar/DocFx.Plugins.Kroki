namespace DocFx.Plugins.Kroki.Renderers
{
  public class ErdRenderer : KrokiRenderer
  {
    public override string Name => nameof(ErdRenderer);

    public override DiagramType DiagramType => DiagramType.Erd;

    public ErdRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
