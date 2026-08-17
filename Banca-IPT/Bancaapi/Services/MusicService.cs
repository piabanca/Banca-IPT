using Bancaapi.Models;      
using Newtonsoft.Json;

namespace Bancaapi.Services;

public class MusicService
{
    private readonly HttpClient _http;

    public MusicService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ArtistModel?> GetArtist(string artist)
    {
        var url = $"https://www.theaudiodb.com/api/v1/json/2/search.php?s={Uri.EscapeDataString(artist)}";
        var json = await _http.GetStringAsync(url);
        var result = JsonConvert.DeserializeObject<ArtistResponse>(json);
        return result?.Artists?.FirstOrDefault();
    }

    public async Task<List<OpenWhydTrack>> GetAdrienTracks()
    {
        var json = await _http.GetStringAsync("https://openwhyd.org/adrien?format=json");
        return JsonConvert.DeserializeObject<List<OpenWhydTrack>>(json) ?? new();
    }

    public async Task<List<OpenWhydTrack>> GetHotElectro()
    {
        var json = await _http.GetStringAsync("https://openwhyd.org/hot/electro?format=json");
        return JsonConvert.DeserializeObject<List<OpenWhydTrack>>(json) ?? new();
    }
}