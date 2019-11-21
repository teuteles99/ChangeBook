using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using ChangeBook.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ChangeBook.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Genero> Generos { get; set; }       

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}