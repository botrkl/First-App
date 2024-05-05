using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.EntitesConfiguration
{
    public class CardActivityConfiguration : IEntityTypeConfiguration<CardActivity>
    {
        public void Configure(EntityTypeBuilder<CardActivity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.TimeOfAction).IsRequired();
            builder.Property(x => x.CardId).IsRequired();
        }
    }
}
