using ATFAL360.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ATFAL360.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions <ApplicationContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
        public DbSet<AtfalMember> Atfals { get; set; }
      


    }
}
