using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoktorskaController : ControllerBase
    {
        [HttpGet("PreuzmiDoktorskeDisertacije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetDoktorskeDisertacije()
        {
            var data = DataProvider.VratiSveDoktorskeDisertacije();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiDoktorskuDisertaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetDoktorskaDisertacija(int id)
        {
            var data = DataProvider.VratiDoktorskuDisertaciju(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajDoktorskuDisertaciju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult AddDoktorskaDisertacija([FromBody] DoktorskaDisertacijaView disertacija)
        {
            var data = DataProvider.SacuvajDoktorskuDisertaciju(disertacija);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, "Uspešno dodata doktorska disertacija.");
        }

        [HttpPut("PromeniDoktorskuDisertaciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult ChangeDoktorskaDisertacija([FromBody] DoktorskaDisertacijaView disertacija)
        {
            var data = DataProvider.IzmeniDoktorskuDisertaciju(disertacija);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno izmenjena doktorska disertacija.");
        }

        [HttpDelete("IzbrisiDoktorskuDisertaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeleteDoktorskaDisertacija(int id)
        {
            var data = DataProvider.ObrisiDoktorskuDisertaciju(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
