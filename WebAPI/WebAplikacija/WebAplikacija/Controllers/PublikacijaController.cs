using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublikacijaController : ControllerBase
    {
        [HttpGet("PreuzmiPublikacije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetPublikacije()
        {
            (bool isError, var publikacije, ErrorMessage? error) = DataProvider.VratiSvePublikacije();

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            return Ok(publikacije);
        }

        [HttpGet("PreuzmiPublikaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetPublikacija(int id)
        {
            (bool isError, var publikacija, ErrorMessage? error) = await DataProvider.VratiPublikacijuAsync(id);

            if (isError)
            {
                return StatusCode(error?.StatusCode ?? 400, error?.Message);
            }

            if (publikacija == null)
            {
                return BadRequest("Publikacija nije pronađena.");
            }

            return Ok(publikacija);
        }

        //
        // DODAVANJE I IZMENA SE IZVRSAVAJU PREKO KONTROLERA ZA SPECIJALIZACIJE!!!
        //

        //[HttpPost("DodajPublikaciju")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        //public async Task<IActionResult> AddPublikacija([FromBody] PublikacijaView p)
        //{
        //    var data = await DataProvider.DodajPublikacijuAsync(p);

        //    if (data.IsError)
        //    {
        //        return StatusCode(data.Error.StatusCode, data.Error.Message);
        //    }

        //    return StatusCode(201, $"Uspešno dodata publikacija. Naslov: {p.Naslov}");
        //}

        //[HttpPut("PromeniPublikaciju")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status403Forbidden)]
        //public async Task<IActionResult> ChangePublikacija([FromBody] PublikacijaView p)
        //{
        //    (bool isError, var publikacija, ErrorMessage? error) = await DataProvider.AzurirajPublikacijuAsync(p);

        //    if (isError)
        //    {
        //        return StatusCode(error?.StatusCode ?? 400, error?.Message);
        //    }

        //    if (publikacija == null)
        //    {
        //        return BadRequest("Publikacija nije validna.");
        //    }

        //    return Ok($"Uspešno ažurirana publikacija. Naslov: {publikacija.Naslov}");
        //}

        [HttpDelete("IzbrisiPublikaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeletePublikacija(int id)
        {
            var data = await DataProvider.ObrisiPublikacijuAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(204, $"Uspešno obrisana publikacija. ID: {id}");
        }

        // Visevrednosni atributi
        [HttpPost("DodajKljucnuRec/{publikacijaId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AddKljucnaRec(int publikacijaId, [FromBody] PublikacijaKljucnaRecView kljucnaRec)
        {
            var data = await DataProvider.SacuvajKljucnuRecAsync(kljucnaRec, publikacijaId);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return StatusCode(201, "Uspešno dodata ključna reč.");
        }

        [HttpDelete("IzbrisiKljucnuRec/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteKljucnaRec(int id)
        {
            var data = await DataProvider.ObrisiKljucnuRecAsync(id);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return NoContent();
        }

        [HttpGet]
        [HttpGet("PreuzmiKljucneReci/{publikacijaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetKljucneReci(int publikacijaId)
        {
            var data = DataProvider.VratiKljucneReciPublikacije(publikacijaId);

            if (data.IsError)
            {
                return StatusCode(data.Error.StatusCode, data.Error.Message);
            }

            return Ok(data.Data);
        }
    }
}
