namespace PersonalProjectManagementTool.BLL.Models
{
    public class CardActivityModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfAction { get; set; }
        public Guid CardId { get; set; }
    }
}
