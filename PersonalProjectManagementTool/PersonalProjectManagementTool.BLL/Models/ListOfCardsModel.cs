using PersonalProjectManagementTool.DAL.Entities;

namespace PersonalProjectManagementTool.BLL.Models
{
    public class ListOfCardsModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<CardModel>? Cards { get; set; }
    }
}
