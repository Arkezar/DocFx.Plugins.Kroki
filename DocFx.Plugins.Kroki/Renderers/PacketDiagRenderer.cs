namespace DocFx.Plugins.Kroki.Renderers
{
  public class PacketDiagRenderer : KrokiRenderer
  {
    public override string Name => nameof(PacketDiagRenderer);

    public override DiagramType DiagramType => DiagramType.PacketDiag;

    public PacketDiagRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
