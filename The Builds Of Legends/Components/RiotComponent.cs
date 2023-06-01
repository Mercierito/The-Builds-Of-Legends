using The_Builds_of_Legends.IComponents;
using The_Builds_of_Legends.IRepositories;
using The_Builds_of_Legends.Models.DataDragon;

namespace The_Builds_of_Legends.Components
{
    public class RiotComponent : IRiotComponent
    {
        private IRiotRepository _riotRepository;

        public RiotComponent(IRiotRepository riotRepository)
        {
            _riotRepository = riotRepository;
        }

        public Task<int> GetMatchHistory(string queue)
        {
            throw new NotImplementedException();
        }

        public DataDragonChampionResponse UpdateChampionDb()
        {
            return  _riotRepository.GetChampions().Result;

            
        }
    }
}
