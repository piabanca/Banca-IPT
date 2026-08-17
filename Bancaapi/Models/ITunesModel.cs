using Newtonsoft.Json;

namespace Bancaapi.Models
{
    public class ITunesResponse
    {
        [JsonProperty("results")]
        public List<ITunesTrack>? Results { get; set; }
    }

    public class ITunesTrack
    {
        [JsonProperty("trackName")]
        public string? TrackName { get; set; }

        [JsonProperty("artistName")]
        public string? ArtistName { get; set; }

        [JsonProperty("artworkUrl100")]
        public string? ArtworkUrl { get; set; }

        [JsonProperty("collectionName")]
        public string? CollectionName { get; set; }
    }
}