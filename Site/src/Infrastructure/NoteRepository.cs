using Application;
using Domain;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Infrastructure;

public class NoteRepository : INoteRepository
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public NoteRepository(HttpClient httpClient,
        IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<IEnumerable<Note>> GetNotes()
    {
        var baseUrl = _configuration["SnipprApiUrl"];
        if (string.IsNullOrWhiteSpace(baseUrl))
            return Enumerable.Empty<Note>();

        var response = await _httpClient.PostAsync(baseUrl, new StringContent(string.Empty));
        if (!response.IsSuccessStatusCode)
            throw new Exception("Failure");

        return JsonSerializer.Deserialize<IEnumerable<Note>>(await response.Content.ReadAsStringAsync()) ?? Enumerable.Empty<Note>();
    }
}
