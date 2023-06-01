namespace The_Builds_of_Legends.Models.DataDragon
{
    public class DataDragonChampion 
    {
       
       
        public string name { get; set; }        
        public DataDragonImage image { get; set; }
        public string[] tags { get; set; }
        public string partype { get; set; }

        public DataDragonStat stats { get; set; }
        public DataDragonSpell[] spells { get; set; }
    }
}
