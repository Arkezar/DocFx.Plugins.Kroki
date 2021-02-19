namespace DocFx.Plugins.Kroki.Renderers
{
  public class PlantUmlRenderer : KrokiRenderer
  {
    public override string Name => nameof(PlantUmlRenderer);

    public override DiagramType DiagramType => DiagramType.PlantUML;

    public PlantUmlRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
