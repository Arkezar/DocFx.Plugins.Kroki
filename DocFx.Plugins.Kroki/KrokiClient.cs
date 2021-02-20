using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DocFx.Plugins.Kroki
{
  public class KrokiClient
  {
    private readonly Uri _requestUrl;

    public KrokiClient(Uri requestUrl)
    {
      _requestUrl = requestUrl;
    }

    public async Task<byte[]> GetDiagram(KrokiPayload payload)
    {
      using (var client = new HttpClient())
      {
        var content = PrepareRequestContent(payload);
        var response = await client.PostAsync(_requestUrl, content);
        return await response.Content.ReadAsByteArrayAsync();
      }
    }

    private HttpContent PrepareRequestContent(KrokiPayload payload)
    {
      var jsonContent = JsonConvert.SerializeObject(payload);
      var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
      return content;
    }
  }
}
