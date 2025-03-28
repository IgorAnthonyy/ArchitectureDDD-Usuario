using ArchitectureDDDUsuario.Domain.Entities;
using ArchitectureDDDUsuario.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureDDDUsuario.Application.Services;

public class UsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<Usuario> CriarUsuarioAsync(Usuario usuario)
    {
        return await _usuarioRepository.AdicionarAsync(usuario);
    }

    public async Task<Usuario> ObterUsuarioAsync(string id)
    {
        return await _usuarioRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Usuario>> ListarUsuariosAsync()
    {
        return await _usuarioRepository.ObterTodosAsync();
    }

    public async Task DeletarUsuarioAsync(string id)
    {
        await _usuarioRepository.RemoverAsync(id);
    }

    public async Task AtualizarUsuarioAsync(Usuario usuario)
    {
        await _usuarioRepository.AtualizarAsync(usuario);
    }
}
