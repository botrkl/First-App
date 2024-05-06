namespace PersonalProjectManagementTool.API.DTOs
{
    public class CardActivityDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfAction { get; set; }
        public Guid CardId { get; set; }
    }
}
