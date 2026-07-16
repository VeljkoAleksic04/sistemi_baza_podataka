using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IstrazivacController : ControllerBase
    {
        [HttpGet("PreuzmiIstrazivace")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetIstrazivaci()
        {
            var data = DataProvider.VratiSveIstrazivace();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiIstrazivaca/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetIstrazivac(int id)
        {
            var data = await DataProvider.VratiIstrazivacaAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajIstrazivaca")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddIstrazivac([FromBody] IstrazivacView dto)
        {
            var data = await DataProvider.DodajIstrazivacaAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodat istraživač. Ime: {dto.Ime} {dto.Prezime}");
        }

        [HttpPut("PromeniIstrazivaca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeIstrazivac([FromBody] IstrazivacView dto)
        {
            var data = await DataProvider.AzurirajIstrazivacaAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok($"Uspešno ažuriran istraživač. Ime: {data.Data.Ime} {data.Data.Prezime}");
        }

        [HttpDelete("IzbrisiIstrazivaca/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteIstrazivac(int id)
        {
            var data = await DataProvider.ObrisiIstrazivacaAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

        [HttpGet("PreuzmiEmailove/{idIstrazivaca}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetEmailovi(int idIstrazivaca)
        {
            var data = DataProvider.VratiEmailoveIstrazivaca(idIstrazivaca);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiEmail/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetEmail(int id)
        {
            var data = await DataProvider.VratiEmailAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajEmail/{idIstrazivaca}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddEmail(int idIstrazivaca, [FromBody] IstrazivacEmailView dto)
        {
            var data = await DataProvider.DodajEmailAsync(dto, idIstrazivaca);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodat email. ID: {data.Data}");
        }

        [HttpPut("PromeniEmail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeEmail([FromBody] IstrazivacEmailView dto)
        {
            var data = await DataProvider.AzurirajEmailAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažuriran email.");
        }

        [HttpDelete("IzbrisiEmail/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteEmail(int id)
        {
            var data = await DataProvider.ObrisiEmailAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

        [HttpGet("PreuzmiTelefone/{idIstrazivaca}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetTelefoni(int idIstrazivaca)
        {
            var data = DataProvider.VratiTelefoneIstrazivaca(idIstrazivaca);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiTelefon/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetTelefon(int id)
        {
            var data = await DataProvider.VratiTelefonAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajTelefon/{idIstrazivaca}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddTelefon(int idIstrazivaca, [FromBody] IstrazivacTelefonView dto)
        {
            var data = await DataProvider.DodajTelefonAsync(dto, idIstrazivaca);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodat telefon. ID: {data.Data}");
        }

        [HttpPut("PromeniTelefon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeTelefon([FromBody] IstrazivacTelefonView dto)
        {
            var data = await DataProvider.AzurirajTelefonAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažuriran telefon.");
        }

        [HttpDelete("IzbrisiTelefon/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteTelefon(int id)
        {
            var data = await DataProvider.ObrisiTelefonAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

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

        [HttpGet("PreuzmiPublikacijeAutora/{idAutora}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPublikacijeAutora(int idAutora)
        {
            var data = DataProvider.VratiPublikacijeAutora(idAutora);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }
    }
}
