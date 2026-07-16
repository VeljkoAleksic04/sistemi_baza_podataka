using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class PovezanSaController : ControllerBase
{
    [HttpGet("PreuzmiPovezane/{publikacijaId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetPovezane(int publikacijaId)
    {
        var data = DataProvider.VratiPovezanePublikacije(publikacijaId);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiVezu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetPovezanSa(int id)
    {
        var data = DataProvider.VratiPovezanSa(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajVezu")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddPovezanSa([FromBody] PovezanSaView dto)
    {
        var data = DataProvider.DodajPovezanSa(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodata veza.");
    }

    [HttpPut("PromeniVezu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangePovezanSa([FromBody] PovezanSaView dto)
    {
        var data = DataProvider.IzmeniPovezanSa(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjena veza.");
    }

    [HttpDelete("IzbrisiVezu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeletePovezanSa(int id)
    {
        var data = DataProvider.ObrisiPovezanSa(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}