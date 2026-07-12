using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PoglavljeController : ControllerBase
    {
        [HttpGet("PreuzmiPoglavlja")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPoglavlja()
        {
            var data = DataProvider.VratiSvaPoglavljaUKnjizi();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiPoglavlje/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPoglavlje(int id)
        {
            var data = DataProvider.VratiPoglavljeUKnjizi(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajPoglavlje")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult AddPoglavlje([FromBody] PoglavljeUKnjiziView poglavlje)
        {
            var data = DataProvider.SacuvajPoglavljeUKnjizi(poglavlje);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, "Uspešno dodato poglavlje.");
        }

        [HttpPut("PromeniPoglavlje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult ChangePoglavlje([FromBody] PoglavljeUKnjiziView poglavlje)
        {
            var data = DataProvider.IzmeniPoglavljeUKnjizi(poglavlje);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno izmenjeno poglavlje.");
        }

        [HttpDelete("IzbrisiPoglavlje/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeletePoglavlje(int id)
        {
            var data = DataProvider.ObrisiPoglavljeUKnjizi(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
