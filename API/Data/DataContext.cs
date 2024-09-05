using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
        // Vai criar no banco a tabela "Users", utilizando o model como base "AppUser" para as colunas
        public DbSet<AppUser> Users { get; set; }    
}
