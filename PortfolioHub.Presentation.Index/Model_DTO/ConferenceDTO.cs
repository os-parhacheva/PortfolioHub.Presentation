using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Presentation.Index
{
    public class ConferenceDTO : AchievementDTO
    {
        public string Organizer { get; set; } = ""; // Организатор конференции
        public string Topic { get; set; } = ""; // Тема доклада / участия
        public string Role { get; set; } = ""; // Роль (докладчик, участник)
    }
}
