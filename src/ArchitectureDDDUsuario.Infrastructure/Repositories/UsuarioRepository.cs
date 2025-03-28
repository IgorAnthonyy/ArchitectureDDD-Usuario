using ArchitectureDDDUsuario.Domain.Entities;
using ArchitectureDDDUsuario.Domain.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureDDDUsuario.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly IMongoCollection<Usuario> _usuarios;

    public UsuarioRepository(IMongoDatabase database)
    {
        _usuarios = database.GetCollection<Usuario>("Usuarios");
    }

    public async Task<Usuario> AdicionarAsync(Usuario usuario)
    {
        await _usuarios.InsertOneAsync(usuario);
        return usuario;
    }

    public async Task<Usuario> ObterPorIdAsync(string id) =>
        await _usuarios.Find(u => u.Id == id).FirstOrDefaultAsync();

    public async Task<IEnumerable<Usuario>> ObterTodosAsync() =>
        await _usuarios.Find(_ => true).ToListAsync();

    public async Task<bool> AtualizarAsync(Usuario usuario)
    {
        var resultado = await _usuarios.ReplaceOneAsync(u => u.Id == usuario.Id, usuario);
        return resultado.IsAcknowledged && resultado.ModifiedCount > 0;
    }

    public async Task<bool> RemoverAsync(string id)
    {
        var resultado = await _usuarios.DeleteOneAsync(u => u.Id == id);
        return resultado.IsAcknowledged && resultado.DeletedCount > 0;
    }
}
