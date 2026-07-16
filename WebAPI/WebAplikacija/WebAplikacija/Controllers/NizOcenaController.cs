using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class NizOcenaController : ControllerBase
{
    [HttpGet("PreuzmiOceneRecenzije/{recenzijaId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetOceneRecenzije(int recenzijaId)
    {
        var data = DataProvider.VratiOceneRecenzije(recenzijaId);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiOcenu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetOcena(int id)
    {
        var data = DataProvider.VratiNizOcena(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajOcenu")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddOcena([FromBody] NizOcenaView dto)
    {
        var data = DataProvider.DodajNizOcena(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodata ocena.");
    }

    [HttpPut("PromeniOcenu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangeOcena([FromBody] NizOcenaView dto)
    {
        var data = DataProvider.IzmeniNizOcena(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjena ocena.");
    }

    [HttpDelete("IzbrisiOcenu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeleteOcena(int id)
    {
        var data = DataProvider.ObrisiNizOcena(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}