using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Presentation.Index
{
    public class PublicationDTO : AchievementDTO
    {
        // Журнал/издание
        public string Journal { get; set; } = "";
        // DOI
        public string Doi { get; set; } = "";
        // Список авторов
        public List<AuthorDTO> AuthorDTOs { get; set; } = new();
    }
}
