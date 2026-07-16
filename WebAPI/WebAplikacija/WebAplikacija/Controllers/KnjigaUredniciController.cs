using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class KnjigaUredniciController : ControllerBase
{
    [HttpGet("PreuzmiUrednikeKnjige/{knjigaId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetUrednikeKnjige(int knjigaId)
    {
        var data = DataProvider.VratiUrednikeKnjige(knjigaId);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiUrednikaKnjige/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetKnjigaUrednici(int id)
    {
        var data = DataProvider.VratiKnjigaUrednici(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajUrednikaKnjige")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddKnjigaUrednici([FromBody] KnjigaUredniciView dto)
    {
        var data = DataProvider.DodajKnjigaUrednici(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodat urednik knjige.");
    }

    [HttpPut("PromeniUrednikaKnjige")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangeKnjigaUrednici([FromBody] KnjigaUredniciView dto)
    {
        var data = DataProvider.IzmeniKnjigaUrednici(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjen urednik knjige.");
    }

    [HttpDelete("IzbrisiUrednikaKnjige/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeleteKnjigaUrednici(int id)
    {
        var data = DataProvider.ObrisiKnjigaUrednici(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}