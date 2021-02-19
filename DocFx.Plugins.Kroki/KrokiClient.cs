using System;
using System.Net.Http;
using System.Net.Http.Headers;
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

    public async Task<byte[]> Get(string code, OutputFormat outputFormat)
    {
      using (var client = GetClient())
      {
        var content = PrepareRequestContent(code, outputFormat);
        var response = await client.PostAsync(_requestUrl, content);
        return await response.Content.ReadAsByteArrayAsync();
      }
    }

    private HttpClient GetClient()
    {
      var client = new HttpClient();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("image/svg+xml"));
      return client;
    }

    private HttpContent PrepareRequestContent(string code, OutputFormat outputFormat)
    {
      var content = new StringContent(code);
      content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
      return content;
    }
  }
}
