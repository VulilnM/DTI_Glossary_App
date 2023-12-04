using DTI_Glossary_App.Models;
using Microsoft.EntityFrameworkCore;

namespace DTI_Glossary_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Create table
        public DbSet<Glossary> Glossaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Glossary>().HasData(
            new Glossary
            {
                GlossaryId = 1,
                Term = "Gloss1",
                Definition = "Definition of the glossary number 1"
            },
            new Glossary
            {
                GlossaryId = 2,
                Term = "Gloss2",
                Definition = "Definition of the glossary number 2"
            },
            new Glossary
            {
                GlossaryId = 3,
                Term = "Gloss3",
                Definition = "Definition of the glossary number 3"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
