namespace DocFx.Plugins.Kroki.Renderers
{
  class VegaLiteRenderer : KrokiRenderer
  {
    public override string Name => nameof(VegaLiteRenderer);

    public override DiagramType DiagramType => DiagramType.VegaLite;

    public VegaLiteRenderer(KrokiSettings settings) : base(settings)
    { }
  }
}
