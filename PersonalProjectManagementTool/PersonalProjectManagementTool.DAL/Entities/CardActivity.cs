namespace PersonalProjectManagementTool.DAL.Entities
{
    public class CardActivity : BaseEntity
    {
        public string Description { get; set; }
        public DateTime TimeOfAction { get; set; }
        public Guid CardId { get; set; }
        public virtual Card? Card { get; set; }
    }
}
