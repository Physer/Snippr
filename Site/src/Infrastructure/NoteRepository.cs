using Application;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Infrastructure;

public class NoteRepository : INoteRepository
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;

    public NoteRepository(HttpClient httpClient,
        IConfiguration configuration,
        ILogger<NoteRepository> logger)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _logger = logger;
    }

    public async Task<IEnumerable<Note>> GetNotes()
    {
        var baseUrl = _configuration["SnipprApiUrl"];
        if (string.IsNullOrWhiteSpace(baseUrl))
            return Enumerable.Empty<Note>();

        _logger.LogInformation("Requesting Notes at GraphQL gateway");
        var response = await _httpClient.PostAsync(baseUrl, new StringContent(string.Empty));
        if (!response.IsSuccessStatusCode)
            throw new Exception("Failure");

        return JsonSerializer.Deserialize<IEnumerable<Note>>(await response.Content.ReadAsStringAsync()) ?? Enumerable.Empty<Note>();
    }
}
