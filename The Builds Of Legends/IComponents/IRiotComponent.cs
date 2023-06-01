using The_Builds_of_Legends.Models.DataDragon;

namespace The_Builds_of_Legends.IComponents
{
    public interface IRiotComponent
    {

        public  Task<int> GetMatchHistory(string queue);
        public  DataDragonChampionResponse UpdateChampionDb();
    }
}
