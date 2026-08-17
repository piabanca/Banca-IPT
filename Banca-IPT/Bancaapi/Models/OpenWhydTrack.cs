using Newtonsoft.Json;

namespace Bancaapi.Models; 
public class OpenWhydTrack
{
    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("img")]
    public string? Image { get; set; }

    [JsonProperty("uNm")]
    public string? UserName { get; set; }

    [JsonProperty("eId")]
    public string? TrackId { get; set; }
}