using DocFx.Plugins.Kroki.Renderers;
using Microsoft.DocAsCode.Dfm;
using System.Collections.Generic;
using System.Composition;

namespace DocFx.Plugins.Kroki
{
  [Export(typeof(IDfmCustomizedRendererPartProvider))]
  public class KrokiPartProvider : IDfmCustomizedRendererPartProvider
  {
    public IEnumerable<IDfmCustomizedRendererPart> CreateParts(IReadOnlyDictionary<string, object> parameters)
    {
      var settings = new KrokiSettings(parameters);
      yield return new ActDiagRenderer(settings);
      yield return new BlockDiagRenderer(settings);
      yield return new BpmnRenderer(settings);
      yield return new BytefieldRenderer(settings);
      yield return new C4PlantUmlRenderer(settings);
      yield return new DitaaRenderer(settings);
      yield return new ErdRenderer(settings);
      yield return new ExcalidrawRenderer(settings);
      yield return new GraphVizRenderer(settings);
      yield return new MermaidRenderer(settings);
      yield return new NomnomlRenderer(settings);
      yield return new NwDiagRenderer(settings);
      yield return new PacketDiagRenderer(settings);
      yield return new PlantUmlRenderer(settings);
      yield return new RackDiagRenderer(settings);
      yield return new SeqDiagRenderer(settings);
      yield return new SvgbobRenderer(settings);
      yield return new UmletRenderer(settings);
      yield return new VegaRenderer(settings);
      yield return new VegaLiteRenderer(settings);
      yield return new WaveDromRenderer(settings);
    }
  }
}
