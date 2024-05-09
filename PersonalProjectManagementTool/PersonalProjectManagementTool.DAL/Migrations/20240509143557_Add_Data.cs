using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalProjectManagementTool.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Add_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ListOfCards",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("0cdb7167-0ba7-4fbe-bd09-d088fa7735d7"), "In Progress" },
                    { new Guid("5f643a7a-27fd-4c48-8e88-a6e7c47e0a5c"), "To Do" },
                    { new Guid("d2f7dc78-033f-45d5-8f21-7c6d49d8dc8d"), "In Review" },
                    { new Guid("d6fcb3ec-f628-448a-83eb-50c2c05c2f06"), "Done" }
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "Description", "DueDate", "ListId", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("0def3a95-8553-428b-8992-69a2c26e5a89"), "Conduct analysis of competitors' activities in the market and identify their strengths and weaknesses to develop a strategy.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4593), new Guid("d6fcb3ec-f628-448a-83eb-50c2c05c2f06"), "Medium", "Competitor Analysis" },
                    { new Guid("3957986d-c570-4707-8b6f-0ca11e427bf3"), "Update the user interface design considering the latest trends and user feedback.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4255), new Guid("5f643a7a-27fd-4c48-8e88-a6e7c47e0a5c"), "Hight", "Interface Update" },
                    { new Guid("547d7b7c-284c-488a-a25f-c7c57a214ab1"), "Address identified bugs in the application, including crashes and incorrect data display.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4275), new Guid("0cdb7167-0ba7-4fbe-bd09-d088fa7735d7"), "Low", "Bug Fixing" },
                    { new Guid("6418cbcd-a40d-414a-808a-7b3b758bb837"), "Optimize code and project structure to improve performance and reduce application response time.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4598), new Guid("d6fcb3ec-f628-448a-83eb-50c2c05c2f06"), "Low", "Performance Enhancement" },
                    { new Guid("a7d39050-544e-4f0f-bbc2-5e96d7aa3a0a"), "Prepare a presentation for the project meeting. Includes deadlines, statistics, and key points.", new DateTime(2024, 5, 9, 14, 35, 56, 478, DateTimeKind.Utc).AddTicks(2145), new Guid("5f643a7a-27fd-4c48-8e88-a6e7c47e0a5c"), "Medium", "Project Presentation" },
                    { new Guid("bfb213eb-8c1e-46ca-b48c-a8ef4d89b7e1"), "Conduct testing of new features to ensure compliance with requirements and identify any potential issues before release.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4271), new Guid("5f643a7a-27fd-4c48-8e88-a6e7c47e0a5c"), "Medium", "Functionality Testing" },
                    { new Guid("df6e76a2-5f3a-4467-8abd-6167e6ae01bb"), "Organize a team meeting to discuss project development strategy and task allocation for the near future.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4279), new Guid("0cdb7167-0ba7-4fbe-bd09-d088fa7735d7"), "Medium", "Event Planning" },
                    { new Guid("e5455f01-a16f-4cef-b5e4-c38684733b9d"), "Prepare project documentation for new team members and update existing materials according to changes.", new DateTime(2024, 5, 9, 14, 35, 56, 479, DateTimeKind.Utc).AddTicks(4587), new Guid("d2f7dc78-033f-45d5-8f21-7c6d49d8dc8d"), "Low", "Documentation Preparation" }
                });

            migrationBuilder.InsertData(
                table: "CardActivity",
                columns: new[] { "Id", "CardId", "Description", "TimeOfAction" },
                values: new object[,]
                {
                    { new Guid("1ef85869-c82a-42af-989d-9b99565c763e"), new Guid("0def3a95-8553-428b-8992-69a2c26e5a89"), "Card Competitor Analysis was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(158) },
                    { new Guid("4d240282-cc75-41a6-b502-79f29d835bd1"), new Guid("bfb213eb-8c1e-46ca-b48c-a8ef4d89b7e1"), "Card Functionality Testing was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(139) },
                    { new Guid("51296456-7396-4fcb-9e00-8bb298e65186"), new Guid("547d7b7c-284c-488a-a25f-c7c57a214ab1"), "Card Bug Fixing was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(142) },
                    { new Guid("6296f7a5-defc-4607-85f6-90a114b2fa0b"), new Guid("a7d39050-544e-4f0f-bbc2-5e96d7aa3a0a"), "Card Project Presentation was created.", new DateTime(2024, 5, 9, 14, 35, 56, 480, DateTimeKind.Utc).AddTicks(9389) },
                    { new Guid("6317f454-611d-48bc-934a-80df91650cbe"), new Guid("e5455f01-a16f-4cef-b5e4-c38684733b9d"), "Card Documentation Preparation was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(155) },
                    { new Guid("65e15659-5090-4afc-8fbf-e573bbc0c151"), new Guid("3957986d-c570-4707-8b6f-0ca11e427bf3"), "Card Interface Update was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(132) },
                    { new Guid("d8d5bef8-b957-44e6-8127-0401860778df"), new Guid("df6e76a2-5f3a-4467-8abd-6167e6ae01bb"), "Card Event Planning was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(144) },
                    { new Guid("ef5b6b1f-a834-447d-b16a-ce92677c9111"), new Guid("6418cbcd-a40d-414a-808a-7b3b758bb837"), "Card Performance Enhancement was created.", new DateTime(2024, 5, 9, 14, 35, 56, 481, DateTimeKind.Utc).AddTicks(160) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("1ef85869-c82a-42af-989d-9b99565c763e"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("4d240282-cc75-41a6-b502-79f29d835bd1"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("51296456-7396-4fcb-9e00-8bb298e65186"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("6296f7a5-defc-4607-85f6-90a114b2fa0b"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("6317f454-611d-48bc-934a-80df91650cbe"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("65e15659-5090-4afc-8fbf-e573bbc0c151"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("d8d5bef8-b957-44e6-8127-0401860778df"));

            migrationBuilder.DeleteData(
                table: "CardActivity",
                keyColumn: "Id",
                keyValue: new Guid("ef5b6b1f-a834-447d-b16a-ce92677c9111"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("0def3a95-8553-428b-8992-69a2c26e5a89"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("3957986d-c570-4707-8b6f-0ca11e427bf3"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("547d7b7c-284c-488a-a25f-c7c57a214ab1"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("6418cbcd-a40d-414a-808a-7b3b758bb837"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("a7d39050-544e-4f0f-bbc2-5e96d7aa3a0a"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("bfb213eb-8c1e-46ca-b48c-a8ef4d89b7e1"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("df6e76a2-5f3a-4467-8abd-6167e6ae01bb"));

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "Id",
                keyValue: new Guid("e5455f01-a16f-4cef-b5e4-c38684733b9d"));

            migrationBuilder.DeleteData(
                table: "ListOfCards",
                keyColumn: "Id",
                keyValue: new Guid("0cdb7167-0ba7-4fbe-bd09-d088fa7735d7"));

            migrationBuilder.DeleteData(
                table: "ListOfCards",
                keyColumn: "Id",
                keyValue: new Guid("5f643a7a-27fd-4c48-8e88-a6e7c47e0a5c"));

            migrationBuilder.DeleteData(
                table: "ListOfCards",
                keyColumn: "Id",
                keyValue: new Guid("d2f7dc78-033f-45d5-8f21-7c6d49d8dc8d"));

            migrationBuilder.DeleteData(
                table: "ListOfCards",
                keyColumn: "Id",
                keyValue: new Guid("d6fcb3ec-f628-448a-83eb-50c2c05c2f06"));
        }
    }
}
