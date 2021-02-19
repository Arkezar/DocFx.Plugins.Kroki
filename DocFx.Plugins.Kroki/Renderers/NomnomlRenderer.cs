namespace DocFx.Plugins.Kroki.Renderers
{
  public class NomnomlRenderer : KrokiRenderer
  {
    public override string Name => nameof(NomnomlRenderer);

    public override DiagramType DiagramType => DiagramType.Nomnoml;

    public NomnomlRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
