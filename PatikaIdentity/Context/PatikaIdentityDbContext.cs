using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatikaIdentity.Entites;

namespace PatikaIdentity.Context
{
    public class PatikaIdentityDbContext:IdentityDbContext
    {
        public PatikaIdentityDbContext(DbContextOptions<PatikaIdentityDbContext> options):base(options)
        {
            
        }

        public DbSet<UserEntitiy> User=> Set<UserEntitiy>();
    }
}
