using PersonalProjectManagementTool.BLL.Models;

namespace PersonalProjectManagementTool.API.DTOs
{
    public class LIstOfCardsDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<CardModel>? Cards { get; set; }
    }
}
