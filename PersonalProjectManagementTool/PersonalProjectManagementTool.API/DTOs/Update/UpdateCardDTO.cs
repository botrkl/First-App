namespace PersonalProjectManagementTool.API.DTOs.Update
{
    public class UpdateCardDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string ListId { get; set; }
    }
}
