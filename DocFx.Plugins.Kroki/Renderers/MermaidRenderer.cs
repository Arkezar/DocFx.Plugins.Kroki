namespace DocFx.Plugins.Kroki.Renderers
{
  public class MermaidRenderer : KrokiRenderer
  {
    public override string Name => nameof(MermaidRenderer);

    public override DiagramType DiagramType => DiagramType.Mermaid;

    public MermaidRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
