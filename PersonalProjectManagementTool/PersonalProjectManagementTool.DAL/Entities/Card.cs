namespace PersonalProjectManagementTool.DAL.Entities
{
    public class Card : BaseEntity
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CardActivity> CardActivities { get; set; }
    }
}
