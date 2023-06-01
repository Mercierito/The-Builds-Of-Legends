using The_Builds_of_Legends.IComponents;
using The_Builds_of_Legends.IMappers;
using Microsoft.AspNetCore.Mvc;

namespace The_Builds_of_Legends.Controllers
{
    public class RiotController : Controller
    {
        private IRiotComponent _riotComponent;
        private IRiotMapper _riotMapper;

        public RiotController(IRiotComponent component) 
        {
            _riotComponent = component;
        }

        [HttpGet]
        [Produces("application/json")]
        [Route ("History/{queue}", Name ="GetMatchHistory")]        
        public async Task<IActionResult> GetMatchHistory( string queue) 
        {
            var result = await _riotComponent.GetMatchHistory(queue);

            return Ok(result);
        }

        [HttpPatch]
        [Produces("application/json")]
        [Route ("Champions", Name ="UpdateChampionData")]
        public IActionResult UpdateChampionData()
        {
            var result =  _riotComponent.UpdateChampionDb();
            // -----> put in db
            return Ok(result.data["MonkeyKing"]);
        }


        [HttpPatch]
        [Produces("application/json")]
        [Route("Items", Name = "UpdateItemData")]
        public IActionResult UpdateItemData()
        {
            var result = _riotComponent.UpdateChampionDb();
            return Ok();
        }




    }
}
