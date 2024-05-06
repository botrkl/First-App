using PersonalProjectManagementTool.BLL.Models;

namespace PersonalProjectManagementTool.API.DTOs
{
    public class CardDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public Guid ListId { get; set; }
        public virtual ICollection<CardActivityDTO>? CardActivities { get; set; }
    }
}
