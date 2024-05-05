namespace PersonalProjectManagementTool.BLL.Models.AddModels
{
    public class AddCardModel
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public Guid ListId { get; set; }
    }
}
