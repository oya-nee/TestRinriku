using Microsoft.AspNetCore.Mvc;

namespace TestRinriku.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NeneController : ControllerBase
    {
        [HttpGet("boyfriend")]
        public Person boyfriend()
        {
            Person mume = new Person();
            //mume.Name = "MheePooh";
            //mume.Firstname = "Sirithep";
            //mume.Lastname = "Pukim";

            return mume;
        }

        [HttpGet("sister")]
        public Person sister()
        {
            return new Person
            {
                Name = "Neen",
                Firstname = "Neenny",
                Lastname = "Moo"

            };

        }
    }
}