using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrezentacijaController : ControllerBase
    {
        [HttpGet("PreuzmiPrezentacije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPrezentacije()
        {
            var data = DataProvider.VratiSvePrezentacije();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiPrezentaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPrezentacija(int id)
        {
            var data = DataProvider.VratiPrezentaciju(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajPrezentaciju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult AddPrezentacija([FromBody] PrezentacijaView prezentacija)
        {
            var data = DataProvider.SacuvajPrezentaciju(prezentacija);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, "Uspešno dodata prezentacija.");
        }

        [HttpPut("PromeniPrezentaciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult ChangePrezentacija([FromBody] PrezentacijaView prezentacija)
        {
            var data = DataProvider.IzmeniPrezentaciju(prezentacija);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno izmenjena prezentacija.");
        }

        [HttpDelete("IzbrisiPrezentaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeletePrezentacija(int id)
        {
            var data = DataProvider.ObrisiPrezentaciju(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
