using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task
    {
        /// <summary>
        /// Название задачи.
        /// </summary>
        public string Title {get; set;}

        /// <summary>
        /// Дата и варемя завершения задачи
        /// </summary>
        public DateTime Due { get; set; }

        /// <summary>
        /// Отметка о выполнении задачи
        /// </summary>
        public Boolean Done { get; set; }
    }

}
