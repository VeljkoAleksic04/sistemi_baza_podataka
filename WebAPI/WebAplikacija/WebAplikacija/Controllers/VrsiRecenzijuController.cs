using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class VrsiRecenzijuController : ControllerBase
{
    [HttpGet("PreuzmiRecenzijeRunde/{rundaId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetRecenzijeRunde(int rundaId)
    {
        var data = DataProvider.VratiRecenzijeRunde(rundaId);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiRecenziju/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetRecenzija(int id)
    {
        var data = DataProvider.VratiVrsiRecenziju(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajRecenziju")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddRecenzija([FromBody] VrsiRecenzijuView dto)
    {
        var data = DataProvider.DodajVrsiRecenziju(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodata recenzija.");
    }

    [HttpPut("PromeniRecenziju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangeRecenzija([FromBody] VrsiRecenzijuView dto)
    {
        var data = DataProvider.IzmeniVrsiRecenziju(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjena recenzija.");
    }

    [HttpDelete("IzbrisiRecenziju/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeleteRecenzija(int id)
    {
        var data = DataProvider.ObrisiVrsiRecenziju(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}