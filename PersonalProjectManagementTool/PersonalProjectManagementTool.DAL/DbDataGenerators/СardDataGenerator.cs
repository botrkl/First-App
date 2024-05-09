using Microsoft.EntityFrameworkCore;
using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.DAL.DbDataGenerators
{
    public static class СardDataGenerator
    {
        public static readonly List<Card> cards = new List<Card> 
        {
            new()
            {
                Id =Guid.Parse("A7D39050-544E-4F0F-BBC2-5E96D7AA3A0A"),
                Title = "Project Presentation",
                DueDate = DateTime.UtcNow,
                Priority = "Medium",
                Description ="Prepare a presentation for the project meeting. Includes deadlines, statistics, and key points.",
                ListId = Guid.Parse("5F643A7A-27FD-4C48-8E88-A6E7C47E0A5C")
            },
            new()
            {
                Id =Guid.Parse("3957986D-C570-4707-8B6F-0CA11E427BF3"),
                Title = "Interface Update",
                DueDate = DateTime.UtcNow,
                Priority = "Hight",
                Description ="Update the user interface design considering the latest trends and user feedback.",
                ListId = Guid.Parse("5F643A7A-27FD-4C48-8E88-A6E7C47E0A5C")
            },
            new()
            {
                Id =Guid.Parse("BFB213EB-8C1E-46CA-B48C-A8EF4D89B7E1"),
                Title = "Functionality Testing",
                DueDate = DateTime.UtcNow,
                Priority = "Medium",
                Description ="Conduct testing of new features to ensure compliance with requirements and identify any potential issues before release.",
                ListId = Guid.Parse("5F643A7A-27FD-4C48-8E88-A6E7C47E0A5C")
            },
            new()
            {
                Id =Guid.Parse("547D7B7C-284C-488A-A25F-C7C57A214AB1"),
                Title = "Bug Fixing",
                DueDate = DateTime.UtcNow,
                Priority = "Low",
                Description ="Address identified bugs in the application, including crashes and incorrect data display.",
                ListId = Guid.Parse("0CDB7167-0BA7-4FBE-BD09-D088FA7735D7")
            },
            new()
            {
                Id =Guid.Parse("DF6E76A2-5F3A-4467-8ABD-6167E6AE01BB"),
                Title = "Event Planning",
                DueDate = DateTime.UtcNow,
                Priority = "Medium",
                Description ="Organize a team meeting to discuss project development strategy and task allocation for the near future.",
                ListId = Guid.Parse("0CDB7167-0BA7-4FBE-BD09-D088FA7735D7")
            },
             new()
            {
                Id =Guid.Parse("E5455F01-A16F-4CEF-B5E4-C38684733B9D"),
                Title = "Documentation Preparation",
                DueDate = DateTime.UtcNow,
                Priority = "Low",
                Description ="Prepare project documentation for new team members and update existing materials according to changes.",
                ListId = Guid.Parse("D2F7DC78-033F-45D5-8F21-7C6D49D8DC8D")
            },
              new()
            {
                Id =Guid.Parse("0DEF3A95-8553-428B-8992-69A2C26E5A89"),
                Title = "Competitor Analysis",
                DueDate = DateTime.UtcNow,
                Priority = "Medium",
                Description ="Conduct analysis of competitors' activities in the market and identify their strengths and weaknesses to develop a strategy.",
                ListId = Guid.Parse("D6FCB3EC-F628-448A-83EB-50C2C05C2F06")
            },
               new()
            {
                Id =Guid.Parse("6418CBCD-A40D-414A-808A-7B3B758BB837"),
                Title = "Performance Enhancement",
                DueDate = DateTime.UtcNow,
                Priority = "Low",
                Description ="Optimize code and project structure to improve performance and reduce application response time.",
                ListId = Guid.Parse("D6FCB3EC-F628-448A-83EB-50C2C05C2F06")
            }
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Card>()
                .HasData(cards);
        }
    }
}
