using RestSharp;
using System;
using System.Threading.Tasks;

public class ApiMethods
{
    private readonly RestClient _client;

    public ApiMethods(string baseUrl)
    {
        _client = new RestClient(baseUrl);
    }

    public async Task<IRestResponse> GetAsync(string resource, object queryParams = null)
    {
        var request = new RestRequest(resource, Method.GET);
        if (queryParams != null)
        {
            foreach (var param in queryParams.GetType().GetProperties())
            {
                request.AddQueryParameter(param.Name, param.GetValue(queryParams)?.ToString());
            }
        }
        return await _client.ExecuteAsync(request);
    }

    public async Task<IRestResponse> PostAsync(string resource, object body = null)
    {
        var request = new RestRequest(resource, Method.POST);
        if (body != null)
        {
            request.AddJsonBody(body);
        }
        return await _client.ExecuteAsync(request);
    }

    public async Task<IRestResponse> PutAsync(string resource, object body = null)
    {
        var request = new RestRequest(resource, Method.PUT);
        if (body != null)
        {
            request.AddJsonBody(body);
        }
        return await _client.ExecuteAsync(request);
    }

    public async Task<IRestResponse> PatchAsync(string resource, object body = null)
    {
        var request = new RestRequest(resource, Method.PATCH);
        if (body != null)
        {
            request.AddJsonBody(body);
        }
        return await _client.ExecuteAsync(request);
    }

    public async Task<IRestResponse> DeleteAsync(string resource, object queryParams = null)
    {
        var request = new RestRequest(resource, Method.DELETE);
        if (queryParams != null)
        {
            foreach (var param in queryParams.GetType().GetProperties())
            {
                request.AddQueryParameter(param.Name, param.GetValue(queryParams)?.ToString());
            }
        }
        return await _client.ExecuteAsync(request);
    }
}
