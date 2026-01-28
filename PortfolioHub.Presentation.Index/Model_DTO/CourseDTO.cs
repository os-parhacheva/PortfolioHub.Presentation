using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Presentation.Index
{
    public class CourseDTO : AchievementDTO
    {
        public string Platform { get; set; } = ""; // Платформа (Coursera, Stepik и т.д.)
        public string Certificate { get; set; } = ""; // Сертификат после прохождения
        public int Hours { get; set; } // Количество часов
    }


}
