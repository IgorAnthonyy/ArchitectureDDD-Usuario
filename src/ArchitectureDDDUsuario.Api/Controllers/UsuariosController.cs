using ArchitectureDDDUsuario.Application.Services;
using ArchitectureDDDUsuario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureDDDUsuario.Api.Controllers;

[Route("api/usuarios")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly UsuarioService _usuarioService;

    public UsuariosController(UsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost]
    public async Task<IActionResult> CriarUsuario([FromBody] Usuario usuario)
    {
        var resultado = await _usuarioService.CriarUsuarioAsync(usuario);
        return CreatedAtAction(nameof(ObterUsuario), new { id = resultado.Id }, resultado);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterUsuario(string id)
    {
        var usuario = await _usuarioService.ObterUsuarioAsync(id);
        return usuario != null ? Ok(usuario) : NotFound();
    }

    [HttpGet]
    public async Task<IEnumerable<Usuario>> ListarUsuarios()
    {
        return await _usuarioService.ListarUsuariosAsync();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarUsuario(string id)
    {
        await _usuarioService.DeletarUsuarioAsync(id);
        return NoContent();
    }
    [HttpPut]
    public async Task<IActionResult> AtualizarUsuario([FromBody] Usuario usuario)
    {
        await _usuarioService.AtualizarUsuarioAsync(usuario);
        return NoContent();
    }
}
