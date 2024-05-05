namespace PersonalProjectManagementTool.BLL.Models.UpdateModels
{
    public class UpdateCardModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public Guid ListId { get; set; }
    }
}
