using The_Builds_of_Legends.IRepositories;
using The_Builds_of_Legends.Models;
using The_Builds_of_Legends.Models.DataDragon;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;


namespace The_Builds_of_Legends.Repositories
{
    public class RiotRepository : IRiotRepository
    {
        public async Task<DataDragonChampionResponse> GetChampions()
        {

            var uri = new Uri("http://ddragon.leagueoflegends.com/cdn/13.10.1/data/en_US/championFull.json");
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);

            var responseContent = response.Content.ReadFromJsonAsync<DataDragonChampionResponse>();


            return responseContent.Result;          

            
        }

        public async Task<List<Item>> GetItems()
        {
           

            return null;
        }
    }
}
