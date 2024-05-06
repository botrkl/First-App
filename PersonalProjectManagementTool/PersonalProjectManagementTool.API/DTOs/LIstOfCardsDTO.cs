using PersonalProjectManagementTool.BLL.Models;

namespace PersonalProjectManagementTool.API.DTOs
{
    public class ListOfCardsDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<CardDTO>? Cards { get; set; }
    }
}
