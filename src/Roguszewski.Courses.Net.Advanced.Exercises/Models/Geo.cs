using Newtonsoft.Json;

namespace Roguszewski.Courses.Net.Advanced.Exercises.Models
{
    public partial class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}