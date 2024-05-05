namespace PersonalProjectManagementTool.DAL.Entities
{
    public class ListOfCards : BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection<Card>? Cards { get; set; }
    }
}
