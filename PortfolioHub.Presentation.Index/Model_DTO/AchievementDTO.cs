using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Presentation.Index
{
    public class AchievementDTO
    {
        public Guid Id { get; set; }

        // Название достижения
        public string Title { get; set; } = "";
        // Описание достижения
        public string Description { get; set; } = "";
        // Дата достижения
        public DateTime Date { get; set; } 
        // Ссылка на документ/сайт
        public string Url { get; set; } = "";

        //Дата последнего изменения
        public DateTime EditDate { get; set; }
        //Автор изменения
        public string EditBy { get; set; }

        // Связь с пользователем
        public Guid UserId { get; set; }


    }
}
