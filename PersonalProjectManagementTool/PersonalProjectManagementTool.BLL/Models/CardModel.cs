using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Models
{
    public class CardModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public Guid ListId { get; set; }
        public virtual ICollection<CardActivityModel>? CardActivities { get; set; }
    }
}
