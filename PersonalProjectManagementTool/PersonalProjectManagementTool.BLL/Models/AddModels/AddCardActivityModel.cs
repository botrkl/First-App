namespace PersonalProjectManagementTool.BLL.Models.AddModels
{
    public class AddCardActivityModel
    {
        public string Description { get; set; }
        public DateTime TimeOfAction { get; set; } = DateTime.UtcNow;
        public Guid CardId { get; set; }
    }
}
