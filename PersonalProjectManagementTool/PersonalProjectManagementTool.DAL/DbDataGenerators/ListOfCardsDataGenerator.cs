using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.DbDataGenerators
{
    public static class ListOfCardsDataGenerator
    {
        public static readonly List<ListOfCards> listOfCards = new List<ListOfCards>
        {
            new()
            {
                Id = Guid.Parse("5F643A7A-27FD-4C48-8E88-A6E7C47E0A5C"),
                Title = "To Do"
            },
            new()
            {
                Id = Guid.Parse("0CDB7167-0BA7-4FBE-BD09-D088FA7735D7"),
                Title = "In Progress"
            },
            new()
            {
                Id = Guid.Parse("D2F7DC78-033F-45D5-8F21-7C6D49D8DC8D"),
                Title = "In Review"
            },
            new()
            {
                Id = Guid.Parse("D6FCB3EC-F628-448A-83EB-50C2C05C2F06"),
                Title = "Done"
            }
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<ListOfCards>()
                .HasData(listOfCards);
        }
    }
}
