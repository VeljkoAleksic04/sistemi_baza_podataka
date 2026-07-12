using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObrazovniController : ControllerBase
    {
        [HttpGet("PreuzmiObrazovneMaterijale")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetObrazovniMaterijali()
        {
            var data = DataProvider.VratiSveObrazovneMaterijale();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiObrazovniMaterijal/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetObrazovniMaterijal(int id)
        {
            var data = DataProvider.VratiObrazovniMaterijal(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajObrazovniMaterijal")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult AddObrazovniMaterijal([FromBody] ObrazovniMaterijalView materijal)
        {
            var data = DataProvider.SacuvajObrazovniMaterijal(materijal);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, "Uspešno dodat obrazovni materijal.");
        }

        [HttpPut("PromeniObrazovniMaterijal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult ChangeObrazovniMaterijal([FromBody] ObrazovniMaterijalView materijal)
        {
            var data = DataProvider.IzmeniObrazovniMaterijal(materijal);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno izmenjen obrazovni materijal.");
        }

        [HttpDelete("IzbrisiObrazovniMaterijal/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeleteObrazovniMaterijal(int id)
        {
            var data = DataProvider.ObrisiObrazovniMaterijal(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
