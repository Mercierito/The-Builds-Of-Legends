using The_Builds_of_Legends.IComponents;
using Microsoft.AspNetCore.Mvc;

namespace The_Builds_of_Legends.Controllers
{
    public class BuildController : Controller
    {
        private IBuildComponent _buildComponent;

        public BuildController(IBuildComponent buildComponent) { }

        [HttpGet]
        [Produces("application/json")]
        [Route ("Builds/{userId}",Name ="GetBuilds")]
        public async Task<IActionResult> GetBuilds(string userId)
        {
            return Ok(null);
        }

        [HttpGet]
        [Produces("application/json")]
        [Route ("Build/{buildId}",Name ="GetBuild")]
        public async Task<IActionResult> GetBuild(string buildId)
        {
            return Ok(null);
        }

        [HttpPost]
        [Produces("application/json")]
        [Route ("Build",Name ="PostBuild")]
        public async Task<IActionResult> PostBuild() //pas bon
        {
            return Ok(null);
        }

        [HttpDelete]
        [Produces("application/json")]
        [Route ("Build/{buildId}",Name ="DeleteBuild")]
        public async Task<IActionResult> DeleteBuild(string buildId)
        {
            return BadRequest();
        }
    }
}
