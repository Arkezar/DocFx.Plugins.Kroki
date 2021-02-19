namespace DocFx.Plugins.Kroki.Renderers
{
  public class ExcalidrawRenderer : KrokiRenderer
  {
    public override string Name => nameof(ExcalidrawRenderer);

    public override DiagramType DiagramType => DiagramType.Excalidraw;

    public ExcalidrawRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
