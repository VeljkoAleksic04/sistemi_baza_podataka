using Microsoft.AspNetCore.Mvc;
using RepozitorijumLibrary;
using RepozitorijumLibrary.DTOs;

namespace WebAplikacija.Controllers;

[ApiController]
[Route("[controller]")]
public class SoftverskiArtefaktController : ControllerBase
{
    [HttpGet("PreuzmiSoftverskeArtefakte")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetSoftverskiArtefakti()
    {
        var data = DataProvider.VratiSveSoftverskeArtefakte();
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpGet("PreuzmiSoftverskiArtefakt/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetSoftverskiArtefakt(int id)
    {
        var data = DataProvider.VratiSoftverskiArtefakt(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajSoftverskiArtefakt")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddSoftverskiArtefakt([FromBody] SoftverskiArtefaktView dto)
    {
        var data = DataProvider.SacuvajSoftverskiArtefakt(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodat softverski artefakt.");
    }

    [HttpPut("PromeniSoftverskiArtefakt")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangeSoftverskiArtefakt([FromBody] SoftverskiArtefaktView dto)
    {
        var data = DataProvider.IzmeniSoftverskiArtefakt(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjen softverski artefakt.");
    }

    [HttpDelete("IzbrisiSoftverskiArtefakt/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeleteSoftverskiArtefakt(int id)
    {
        var data = DataProvider.ObrisiSoftverskiArtefakt(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }

    // Platforme
    [HttpGet("PreuzmiPlatforme/{idArtefakta}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult GetPlatforme(int idArtefakta)
    {
        var data = DataProvider.VratiPlatformeArtefakta(idArtefakta);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok(data.Data);
    }

    [HttpPost("DodajPlatformu")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult AddPlatforma([FromBody] SoftverskiArtefaktPodrzanePlatformeView dto)
    {
        var data = DataProvider.DodajPlatformu(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return StatusCode(201, "Uspešno dodata platforma.");
    }

    [HttpPut("PromeniPlatformu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult ChangePlatforma([FromBody] SoftverskiArtefaktPodrzanePlatformeView dto)
    {
        var data = DataProvider.IzmeniPlatformu(dto);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return Ok("Uspešno izmenjena platforma.");
    }

    [HttpDelete("IzbrisiPlatformu/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult DeletePlatforma(int id)
    {
        var data = DataProvider.ObrisiPlatformu(id);
        if (data.IsError)
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        return NoContent();
    }
}