namespace ArchitectureDDDUsuario.Domain.Entities;

public class Usuario
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}