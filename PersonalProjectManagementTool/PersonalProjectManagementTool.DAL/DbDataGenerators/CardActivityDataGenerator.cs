using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.DbDataGenerators
{
    public static class CardActivityDataGenerator
    {
        public static readonly List<CardActivity> cardActivities = new List<CardActivity>
        {
            new()
            {
                Id=Guid.Parse("6296F7A5-DEFC-4607-85F6-90A114B2FA0B"),
                Description = "Card Project Presentation was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("A7D39050-544E-4F0F-BBC2-5E96D7AA3A0A")
            },
            new()
            {
                Id=Guid.Parse("65E15659-5090-4AFC-8FBF-E573BBC0C151"),
                Description = "Card Interface Update was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("3957986D-C570-4707-8B6F-0CA11E427BF3")
            },
            new()
            {
                Id=Guid.Parse("4D240282-CC75-41A6-B502-79F29D835BD1"),
                Description = "Card Functionality Testing was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("BFB213EB-8C1E-46CA-B48C-A8EF4D89B7E1")
            },
            new()
            {
                Id=Guid.Parse("51296456-7396-4FCB-9E00-8BB298E65186"),
                Description = "Card Bug Fixing was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("547D7B7C-284C-488A-A25F-C7C57A214AB1")
            },
            new()
            {
                Id=Guid.Parse("D8D5BEF8-B957-44E6-8127-0401860778DF"),
                Description = "Card Event Planning was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("DF6E76A2-5F3A-4467-8ABD-6167E6AE01BB")
            },
            new()
            {
                Id=Guid.Parse("6317F454-611D-48BC-934A-80DF91650CBE"),
                Description = "Card Documentation Preparation was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("E5455F01-A16F-4CEF-B5E4-C38684733B9D")
            },
            new()
            {
                Id=Guid.Parse("1EF85869-C82A-42AF-989D-9B99565C763E"),
                Description = "Card Competitor Analysis was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("0DEF3A95-8553-428B-8992-69A2C26E5A89")
            },
            new()
            {
                Id=Guid.Parse("EF5B6B1F-A834-447D-B16A-CE92677C9111"),
                Description = "Card Performance Enhancement was created.",
                TimeOfAction = DateTime.UtcNow,
                CardId = Guid.Parse("6418CBCD-A40D-414A-808A-7B3B758BB837")
            }
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<CardActivity>()
                .HasData(cardActivities);
        }
    }
}
