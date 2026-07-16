using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AngazovanjeController : ControllerBase
    {
        [HttpGet("PreuzmiAngazovanjaIstrazivaca/{idIstrazivaca}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetAngazovanjaIstrazivaca(int idIstrazivaca)
        {
            var data = DataProvider.VratiAngazovanjaIstrazivaca(idIstrazivaca);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiAngazovanjaInstitucije/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetAngazovanjaInstitucije(int idInstitucije)
        {
            var data = DataProvider.VratiAngazovanjaInstitucije(idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiAngazovanje/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAngazovanje(int id)
        {
            var data = await DataProvider.VratiAngazovanjeAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajAngazovanje")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddAngazovanje([FromBody] AngazovanjeView dto)
        {
            var data = await DataProvider.DodajAngazovanjeAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodato angažovanje.");
        }

        [HttpPut("PromeniAngazovanje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeAngazovanje([FromBody] AngazovanjeView dto)
        {
            var data = await DataProvider.AzurirajAngazovanjeAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažurirano angažovanje.");
        }

        [HttpDelete("IzbrisiAngazovanje/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteAngazovanje(int id)
        {
            var data = await DataProvider.ObrisiAngazovanjeAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
