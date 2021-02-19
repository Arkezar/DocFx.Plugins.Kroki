namespace DocFx.Plugins.Kroki.Renderers
{
  public class BytefieldRenderer : KrokiRenderer
  {
    public override string Name => nameof(BytefieldRenderer);

    public override DiagramType DiagramType => DiagramType.Bytefield;

    public BytefieldRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
