namespace DocFx.Plugins.Kroki.Renderers
{
  public class GraphVizRenderer : KrokiRenderer
  {
    public override string Name => nameof(GraphVizRenderer);

    public override DiagramType DiagramType => DiagramType.GraphViz;

    public GraphVizRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
