using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.EntitesConfiguration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.DueDate).IsRequired();
            builder.Property(x => x.Priority).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ListId).IsRequired();

            builder.HasMany(card => card.CardActivities)
                .WithOne(ca => ca.Card)
                .HasForeignKey(ca => ca.CardId);
        }
    }
}
