using Microsoft.AspNetCore.Http.HttpResults;
using static System.Net.WebRequestMethods;

namespace BlazorWebApp1.APIs;

public class PublicApisService
{
    HttpClient client;
    string meowFactsUrl = "https://meowfacts.herokuapp.com/";

    public PublicApisService(HttpClient client)
    {
        this.client = client;
    }

    public async Task<CatFactsResponse?> GetMeowFacts(int count)
    {
        // call 

        var result = await client.GetAsync(meowFactsUrl + $"?count={count}");

        result.EnsureSuccessStatusCode();

        var content = await result.Content.ReadFromJsonAsync<CatFactsResponse>();

        return content;
    }

    public async Task<byte[]> GetStatusCodeImage(int statusCode)
    {
        var result = await client.GetAsync($"https://http.cat/{statusCode}");

        result.EnsureSuccessStatusCode();

        var stream = await result.Content.ReadAsByteArrayAsync();

        return stream;
    }
}

public class CatFactsResponse
{
    public string[] Data { get; set; }
}