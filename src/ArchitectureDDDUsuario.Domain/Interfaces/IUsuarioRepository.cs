using System.Collections.Generic;
using System.Threading.Tasks;
using ArchitectureDDDUsuario.Domain.Entities;

namespace ArchitectureDDDUsuario.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario> AdicionarAsync(Usuario usuario);
    Task<Usuario> ObterPorIdAsync(string id);
    Task<IEnumerable<Usuario>> ObterTodosAsync();
    Task<bool> AtualizarAsync(Usuario usuario);
    Task<bool> RemoverAsync(string id);
}