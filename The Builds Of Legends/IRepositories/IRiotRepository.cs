using The_Builds_of_Legends.Models;
using The_Builds_of_Legends.Models.DataDragon;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace The_Builds_of_Legends.IRepositories
{
    public interface IRiotRepository
    {

        public Task<DataDragonChampionResponse> GetChampions();
        public Task<List<Item>> GetItems();
    }
}
