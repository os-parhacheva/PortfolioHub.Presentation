using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Presentation.Index 
{
    public class CompetitionDTO : AchievementDTO
    {
        // Организатор конкурса
        public string Organizer { get; set; } = "";
        // Тип конкурса
        public string Type { get; set; } = "";
        // Формат проведения
        public string View { get; set; } = "";
        // Результат (победитель, призер, участник)
        public string Result { get; set; } = "";
        // Сертификат/документ
        public string Certificate { get; set; } = "";

        // Этапы конкурса
        public List<StageDTO> StageDTOs { get; set; } = new List<StageDTO>();
    }
}
