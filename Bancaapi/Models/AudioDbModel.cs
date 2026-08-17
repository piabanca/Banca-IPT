using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bancaapi.Models
{
    public class AudioDbResponse
    {
        [JsonProperty("artists")]
        public List<AudioDbArtist>? Artists { get; set; }
    }

    public class AudioDbArtist
    {
        [JsonProperty("strArtist")]
        public string? Name { get; set; }

        [JsonProperty("strArtistThumb")]
        public string? Thumbnail { get; set; }

        [JsonProperty("strBiographyEN")]
        public string? Biography { get; set; }
    }
}