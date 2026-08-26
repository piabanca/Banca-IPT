using Newtonsoft.Json;

namespace Bancaapi.Models;

public class ArtistResponse
{
    [JsonProperty("artists")]
    public List<ArtistModel>? Artists { get; set; }
}

public class ArtistModel
{
    [JsonProperty("strArtist")]
    public string? strArtist { get; set; }

    [JsonProperty("strGenre")]
    public string? strGenre { get; set; }

    [JsonProperty("intFormedYear")]
    public string? intFormedYear { get; set; }

    [JsonProperty("strArtistThumb")]
    public string? strArtistThumb { get; set; }
}