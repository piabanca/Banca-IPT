using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bancaapi.Models
{
    public class MusicBrainzResponse
    {
        [JsonProperty("recordings")]
        public List<MusicBrainzRecording> Recordings { get; set; } = new();
    }

    public class MusicBrainzRecording
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }

        [JsonProperty("artist-credit")]
        public List<MusicBrainzArtistCredit>? ArtistCredit { get; set; }
    }

    public class MusicBrainzArtistCredit
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}