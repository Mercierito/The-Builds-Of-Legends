namespace The_Builds_of_Legends.Models.DataDragon
{
    public class DataDragonItemResponse
    {
        public string type { get; set; }        
        public string version { get; set; }
        public Dictionary<string, DataDragonItem> data { get; set; }
    }
}
