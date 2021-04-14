using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController: ControllerBase
    {
private static List<Character> character = new List<Character>{
   // new Character(),
    new Character{Name = "Tanvir"}
};
        public IActionResult Get()
        {
            return Ok(character);
        }
        
    }
}