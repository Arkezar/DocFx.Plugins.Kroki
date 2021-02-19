namespace DocFx.Plugins.Kroki.Renderers
{
  public class BlockDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(BlockDiagRenderer);

    public override DiagramType DiagramType => DiagramType.BlockDiag;

    public BlockDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
