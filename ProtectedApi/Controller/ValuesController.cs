using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProtectedApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("user-info")]
        public IActionResult GetUserInfo()
        {
            // Retrieve user information (name, section, course)
            var userInfo = new
            {
                Name = "Mary Go",
                Section = "32E1",
                Course = "BSIT"
            };

            // Fun facts about the API creator
            var funFacts = new List<string>
            {
            "New to this topics but eager to learn.",
            "Prioritizing comfort in project navigation.",
            "Finding joy in exploring coding, but more comfy to designing.",
            "Working on improving patience daily.",
            "Actively seeking to expand knowledge.",
            "Enjoying the thrill of discovery.",
            "Finding fulfillment despite occasional stress.",
            "Seeing challenges as opportunities for growth.",
            "Embracing the journey of discovery.",
            "Excited about project possibilities.",

               
            };

            var data = new
            {
                UserInfo = userInfo,
                FunFacts = funFacts
            };

            return Ok(data);
        }
    }
}
