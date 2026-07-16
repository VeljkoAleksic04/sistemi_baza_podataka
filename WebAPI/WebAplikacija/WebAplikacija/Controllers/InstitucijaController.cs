using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstitucijaController : ControllerBase
    {
        [HttpGet("PreuzmiInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetInstitucije()
        {
            var data = DataProvider.VratiSveInstitucije();

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiInstituciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetInstitucija(int id)
        {
            var data = await DataProvider.VratiInstitucijuAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajInstituciju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddInstitucija([FromBody] InstitucijaView dto)
        {
            var data = await DataProvider.DodajInstitucijuAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodata institucija. Naziv: {dto.Naziv}");
        }

        [HttpPut("PromeniInstituciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeInstitucija([FromBody] InstitucijaView dto)
        {
            var data = await DataProvider.AzurirajInstitucijuAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok($"Uspešno ažurirana institucija. Naziv: {data.Data.Naziv}");
        }

        [HttpDelete("IzbrisiInstituciju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteInstitucija(int id)
        {
            var data = await DataProvider.ObrisiInstitucijuAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

        [HttpGet("PreuzmiKontaktMailove/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetKontaktMailovi(int idInstitucije)
        {
            var data = DataProvider.VratiKontaktMailoveInstitucije(idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiKontaktMail/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetKontaktMail(int id)
        {
            var data = await DataProvider.VratiKontaktMailAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajKontaktMail/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddKontaktMail(int idInstitucije, [FromBody] InstitucijaKontaktMailView dto)
        {
            var data = await DataProvider.DodajKontaktMailAsync(dto, idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodat kontakt mail. ID: {data.Data}");
        }

        [HttpPut("PromeniKontaktMail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeKontaktMail([FromBody] InstitucijaKontaktMailView dto)
        {
            var data = await DataProvider.AzurirajKontaktMailAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažuriran kontakt mail.");
        }

        [HttpDelete("IzbrisiKontaktMail/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteKontaktMail(int id)
        {
            var data = await DataProvider.ObrisiKontaktMailAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

        [HttpGet("PreuzmiKontaktTelefone/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetKontaktTelefoni(int idInstitucije)
        {
            var data = DataProvider.VratiKontaktTelefoneInstitucije(idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiKontaktTelefon/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetKontaktTelefon(int id)
        {
            var data = await DataProvider.VratiKontaktTelefonAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajKontaktTelefon/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddKontaktTelefon(int idInstitucije, [FromBody] InstitucijaKontaktTelView dto)
        {
            var data = await DataProvider.DodajKontaktTelefonAsync(dto, idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodat kontakt telefon. ID: {data.Data}");
        }

        [HttpPut("PromeniKontaktTelefon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeKontaktTelefon([FromBody] InstitucijaKontaktTelView dto)
        {
            var data = await DataProvider.AzurirajKontaktTelefonAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažuriran kontakt telefon.");
        }

        [HttpDelete("IzbrisiKontaktTelefon/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteKontaktTelefon(int id)
        {
            var data = await DataProvider.ObrisiKontaktTelefonAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
        }

        [HttpGet("PreuzmiNaucneOblasti/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetNaucneOblasti(int idInstitucije)
        {
            var data = DataProvider.VratiNaucneOblastiInstitucije(idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpGet("PreuzmiNaucnuOblast/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetNaucnaOblast(int id)
        {
            var data = await DataProvider.VratiNaucnuOblastAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok(data.Data);
        }

        [HttpPost("DodajNaucnuOblast/{idInstitucije}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddNaucnaOblast(int idInstitucije, [FromBody] InstitucijaNaucnaOblastView dto)
        {
            var data = await DataProvider.DodajNaucnuOblastAsync(dto, idInstitucije);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return StatusCode(201, $"Uspešno dodata naučna oblast. ID: {data.Data}");
        }

        [HttpPut("PromeniNaucnuOblast")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ChangeNaucnaOblast([FromBody] InstitucijaNaucnaOblastView dto)
        {
            var data = await DataProvider.AzurirajNaucnuOblastAsync(dto);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return Ok("Uspešno ažurirana naučna oblast.");
        }

        [HttpDelete("IzbrisiNaucnuOblast/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteNaucnaOblast(int id)
        {
            var data = await DataProvider.ObrisiNaucnuOblastAsync(id);

            if (data.IsError)
                return StatusCode(data.Error.StatusCode, data.Error.Message);

            return NoContent();
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
    }
}
