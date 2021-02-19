namespace DocFx.Plugins.Kroki.Renderers
{
  public class BpmnRenderer : KrokiRenderer
  {
    public override string Name => nameof(BpmnRenderer);

    public override DiagramType DiagramType => DiagramType.BPMN;

    public BpmnRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
