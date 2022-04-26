using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TaskList
    {
        private string name { get; set; }
        private List<Task> tasks { get; set; }

        public TaskList(string name)
        {
            this.name = name;
        }

        ///<summary>
        /// Возвращает имя списка задач
        /// </summary>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public List<Task> AddTask(Task task)
        {
            tasks.Add(task);

        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }

        }


    }
}