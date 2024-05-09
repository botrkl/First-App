using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.DbDataGenerators;
using PersonalProjectManagementTool.DAL.EntitesConfiguration;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.Context
{
    public class BoardDbContext : DbContext
    {
        public BoardDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<ListOfCards> ListsOfCards { get; set; }
        public DbSet<ListOfCards> Cards { get; set; }
        public DbSet<ListOfCards> CardsActivities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardActivityConfiguration()); ;
            modelBuilder.ApplyConfiguration(new CardConfiguration()); ;
            modelBuilder.ApplyConfiguration(new ListOfCardsConfiguration()); ;

            base.OnModelCreating(modelBuilder);

            ListOfCardsDataGenerator.Generate(modelBuilder);
            СardDataGenerator.Generate(modelBuilder);
            CardActivityDataGenerator.Generate(modelBuilder);
        }
    }
}
