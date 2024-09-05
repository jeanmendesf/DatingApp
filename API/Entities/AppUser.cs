using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    
    [Key] //Podemos especificar qual sera o campo pk da tabela criada pelo Entity Framework
    public int Id { get; set; }
    public required string UserName { get; set; }
}
