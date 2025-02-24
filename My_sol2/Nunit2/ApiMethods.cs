using RestSharp;
using System.Threading.Tasks;

public class ApiMethods
{
    private RestClient _client;

    public ApiMethods(string baseUrl)
    {
        _client = new RestClient(baseUrl);
    }

    public async Task<RestResponse> Get(string resource)
    {
        var request = new RestRequest(resource, Method.Get);
        return await _client.ExecuteAsync(request);
    }

    public async Task<RestResponse> Post(string resource, object body)
    {
        var request = new RestRequest(resource, Method.Post);
        request.AddJsonBody(body);
        return await _client.ExecuteAsync(request);
    }

    public async Task<RestResponse> Put(string resource, object body)
    {
        var request = new RestRequest(resource, Method.Put);
        request.AddJsonBody(body);
        return await _client.ExecuteAsync(request);
    }

    public async Task<RestResponse> Patch(string resource, object body)
    {
        var request = new RestRequest(resource, Method.Patch);
        request.AddJsonBody(body);
        return await _client.ExecuteAsync(request);
    }

    public async Task<RestResponse> Delete(string resource)
    {
        var request = new RestRequest(resource, Method.Delete);
        return await _client.ExecuteAsync(request);
    }
}