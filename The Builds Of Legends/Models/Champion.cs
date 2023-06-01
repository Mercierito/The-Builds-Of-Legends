using System.Text.Json.Serialization;

namespace The_Builds_of_Legends.Models
{
    public class Champion
    {
        [JsonPropertyName("id")]
        private string Name { get; set; }
        [JsonPropertyName("hp")]
        private int Hp { get; set; }
    }
}
