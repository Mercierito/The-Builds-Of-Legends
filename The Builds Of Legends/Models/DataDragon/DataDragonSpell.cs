namespace The_Builds_of_Legends.Models.DataDragon
{
    public class DataDragonSpell
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public LevelTip leveltip { get; set; }
        public int maxrank { get; set; }
        public float[] cooldown { get; set; }
        public string cooldowmBurn { get; set; }
        public float[] cost { get; set; }
        public string costBurn { get; set; }        
        public float[][] effect { get; set; }
        public string[] effectBurn { get; set; }        
        public string costType { get; set; }
        public string maxammo { get; set; }
        public float[] range { get; set; }
        public string rangeBurn { get; set; }
        public DataDragonImage image { get; set; }
        public string ressource { get; set; }
    }
}
