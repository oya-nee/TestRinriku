using Microsoft.AspNetCore.Mvc;
using TestRinriku.Models;

namespace TestRinriku.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NeneController : ControllerBase
    {
       Person nene = new Person{ Firstname = "Chanakarn" };

       string functionA()
        {   

            string firstname = nene.Firstname;
            string? name = nene.Name;
            return name ?? "Sorry I got null";
        }
        
    }
}