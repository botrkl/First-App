using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.EntitesConfiguration
{
    public class ListOfCardsConfiguration : IEntityTypeConfiguration<ListOfCards>
    {
        public void Configure(EntityTypeBuilder<ListOfCards> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired();

            builder.HasMany(l => l.Cards)
                .WithOne(c => c.ListOfCards)
                .HasForeignKey(c => c.ListId);
        }
    }
}
