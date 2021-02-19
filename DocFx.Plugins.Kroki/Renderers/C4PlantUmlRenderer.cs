namespace DocFx.Plugins.Kroki.Renderers
{
  public class C4PlantUmlRenderer : KrokiRenderer
  {
    public override string Name => nameof(C4PlantUmlRenderer);

    public override DiagramType DiagramType => DiagramType.C4PlantUML;

    public C4PlantUmlRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
