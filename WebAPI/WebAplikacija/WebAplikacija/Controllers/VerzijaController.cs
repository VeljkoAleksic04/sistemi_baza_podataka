using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VerzijaController : ControllerBase
    {
        [HttpGet("PreuzmiVerzije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetVerzije()
        {
            (bool isError, var verzije, ErrorMessage? error) = DataProvider.VratiSveVerzije();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(verzije);
        }

        [HttpGet("PreuzmiVerziju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetVerzija(int id)
        {
            (bool isError, var verzija, ErrorMessage? error) = await DataProvider.VratiVerzijuAsync(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (verzija == null)
            {
                return BadRequest("Verzija nije pronađena.");
            }

            return Ok(verzija);
        }

        [HttpPost("VratiVerzijePublikacije/{publikacijaId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult VratiVerzijePublikacije(int publikacijaId)
        {
            (bool isError, var verzije, ErrorMessage? error) = DataProvider.VratiVerzijePublikacije(publikacijaId);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(verzije);
        }

        [HttpPost("DodajVerziju/{publikacijaId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddVerzija(int publikacijaId, [FromBody] VerzijaView v)
        {
            var data = await DataProvider.SacuvajVerzijuAsync(v, publikacijaId);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodata verzija. ID: {v.Id}");
        }

        [HttpPut("PromeniVerziju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeVerzija([FromBody] VerzijaView v)
        {
            (bool isError, var verzija, ErrorMessage? error) = await DataProvider.AzurirajVerzijuAsync(v);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (verzija == null)
            {
                return BadRequest("Verzija nije validna.");
            }

            return Ok($"Uspešno ažurirana verzija. ID: {verzija.Id}");
        }

        [HttpDelete("IzbrisiVerziju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteVerzija(int id)
        {
            var data = await DataProvider.ObrisiVerzijuAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisana verzija. ID: {id}");
        }

        // Visevrednosni atributi
        [HttpPost("DodajFajl/{verzijaId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddFajl(int verzijaId, [FromBody] FajlView fajl)
        {
            var data = await DataProvider.SacuvajFajlAsync(fajl, verzijaId);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, $"Uspešno dodat fajl. ID: {data.Data}");
        }

        [HttpDelete("IzbrisiFajl/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult DeleteFajl(int id)
        {
            var data = DataProvider.ObrisiFajl(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return NoContent();
        }

        [HttpGet("PreuzmiFajlove/{verzijaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetFajlovi(int verzijaId)
        {
            var data = DataProvider.VratiFajloveVerzije(verzijaId);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return Ok(data.Data);
        }
    }
}
