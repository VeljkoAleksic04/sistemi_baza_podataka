using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KnjigaController : ControllerBase
    {
        [HttpGet("PreuzmiKnjige")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetKnjige()
        {
            var data = DataProvider.VratiSveKnjige();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiKnjigu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetKnjiga(int id)
        {
            var data = await DataProvider.VratiKnjiguAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajKnjigu")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddKnjiga([FromBody] KnjigaView knjiga)
        {
            var data = await DataProvider.SacuvajKnjiguAsync(knjiga);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodata knjiga. ID: {data.Data}");
        }

        [HttpPut("PromeniKnjigu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeKnjiga([FromBody] KnjigaView knjiga)
        {
            var data = await DataProvider.IzmeniKnjiguAsync(knjiga);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok($"Uspešno izmenjena knjiga.");
        }

        [HttpDelete("IzbrisiKnjigu/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteKnjiga(int id)
        {
            var data = await DataProvider.ObrisiKnjiguAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }
    }
}
