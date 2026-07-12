using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TehnickiController : ControllerBase
    {
        [HttpGet("PreuzmiTehnickeIzvestaje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetTehnickiIzvestaji()
        {
            var data = DataProvider.VratiSveTehnickeIzvestaje();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiTehnickiIzvestaj/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetTehnickiIzvestaj(int id)
        {
            var data = DataProvider.VratiTehnickiIzvestaj(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult AddTehnickiIzvestaj([FromBody] TehnickiIzvestajView izvestaj)
        {
            var data = DataProvider.SacuvajTehnickiIzvestaj(izvestaj);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, "Uspešno dodat tehnički izveštaj.");
        }

        [HttpPut("PromeniTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult ChangeTehnickiIzvestaj([FromBody] TehnickiIzvestajView izvestaj)
        {
            var data = DataProvider.IzmeniTehnickiIzvestaj(izvestaj);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno izmenjen tehnički izveštaj.");
        }

        [HttpDelete("IzbrisiTehnickiIzvestaj/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeleteTehnickiIzvestaj(int id)
        {
            var data = DataProvider.ObrisiTehnickiIzvestaj(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
