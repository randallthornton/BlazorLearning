using Microsoft.AspNetCore.Http.HttpResults;
using static System.Net.WebRequestMethods;

namespace BlazorWebApp1.APIs;

public class PublicApisService
{
	HttpClient client;
	string meowFactsUrl = "https://meowfacts.herokuapp.com/?count=3";

	public PublicApisService(HttpClient client)
	{
		this.client = client;
	}

	public async Task<CatFactsResponse?> GetMeowFacts()
	{
		// call 

		var result = await client.GetAsync(meowFactsUrl);

		result.EnsureSuccessStatusCode();

		var content = await result.Content.ReadFromJsonAsync<CatFactsResponse>();

		return content;
	}
}

public class CatFactsResponse
{
    public string[] Data { get; set; }
}