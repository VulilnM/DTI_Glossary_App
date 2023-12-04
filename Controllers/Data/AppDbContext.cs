using DTI_Glossary_App.Models;
using Microsoft.EntityFrameworkCore;

namespace DTI_Glossary_App.Controllers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        // Create table
        public DbSet<Glossary> Glossaries { get; set; }
        

    }
}
