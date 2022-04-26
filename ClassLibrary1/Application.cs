using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Application
    {
        public static Application application { get; set; }
        public List<TaskList> taskLists { get; set; }

        private Application()
        {
            taskLists = new List<TaskList>();
        }

        /// <summary>
        /// Возвращает ссылку на экземпляр приложения, а в его отсутсвие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application == null)
            {
                return new Application();
            }
            return application;
        }

        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskList
        /// </summary>
        /// <param name="name"></param>
        public TaskList CreateTaskList(String name)
        {
            taskLists.Add(new TaskList(name));
        }
        /// <summary>
        /// возвращает имена списков задач.
        /// </summary>
        /// <returns></returns>
        public string GetTaskListNames()
        {
            var taskList = taskLists.FirstOrDefault(t => t.GetName() == name);
            return taskList;
        }
        /// <summary>
        /// получает задачи запланированные на сегодня в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> tasks = new List<Task>();

            foreach (var taskList in taskLists)
            {
                tasks.AddRange(taskList.GetTasksByToday());
            }

            return tasks;
        }
        /// <summary>
        /// Возвращает задачи на завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasks = new List<Task>();

            foreach (var taskList in taskLists)
            {
                tasks.AddRange(taskList.GetTasksByFuture());
            }

            return tasks;
        }
    }
}
