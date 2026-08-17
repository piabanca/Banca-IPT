using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bancaapi.Models
{
    public class DeezerAlbumResponse
    {
        [JsonProperty("data")]
        public List<DeezerAlbum>? Data { get; set; }
    }

    public class DeezerAlbum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = "";

        [JsonProperty("cover_medium")]
        public string CoverMedium { get; set; } = "";

        [JsonProperty("link")]
        public string Link { get; set; } = "";

        [JsonProperty("artist")]
        public DeezerArtist Artist { get; set; } = new();
    }

    public class DeezerArtist
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "";
    }
}