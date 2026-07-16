using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class PoglavljeUredniciController : ControllerBase
{
    [HttpGet("PreuzmiUrednikePoglavlja/{poglavljeId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetUrednikePoglavlja(int poglavljeId)
    {
        var data = DataProvider.VratiUrednikePoglavlja(poglavljeId);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiUrednikaPoglavlja/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetPoglavljeUrednici(int id)
    {
        var data = DataProvider.VratiPoglavljeUrednici(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajUrednikaPoglavlja")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddPoglavljeUrednici([FromBody] PoglavljeUredniciView dto)
    {
        var data = DataProvider.DodajPoglavljeUrednici(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodat urednik poglavlja.");
    }

    [HttpPut("PromeniUrednikaPoglavlja")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangePoglavljeUrednici([FromBody] PoglavljeUredniciView dto)
    {
        var data = DataProvider.IzmeniPoglavljeUrednici(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjen urednik poglavlja.");
    }

    [HttpDelete("IzbrisiUrednikaPoglavlja/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeletePoglavljeUrednici(int id)
    {
        var data = DataProvider.ObrisiPoglavljeUrednici(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}