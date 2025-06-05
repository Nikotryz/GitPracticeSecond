using Newtonsoft.Json;
namespace GitPractice
{
    public class TaskHelper
    {
        private const string DATA_PATH = "GitPractice.data.json";

        public List<TaskModel>? GetAllTasks()
        {
            var data = File.ReadAllText(DATA_PATH);
            var tasks = JsonConvert.DeserializeObject<List<TaskModel>>(data);
            return tasks?.OrderBy(x => x.Id).ToList();
        }

        public TaskModel? GetTaskById(int id)
        {
            var tasks = GetAllTasks();
            return tasks?.SingleOrDefault(x => x.Id == id);
        }

        public void CreateTask(TaskModel task)
        {
            var tasks = GetAllTasks();
            string data = string.Empty;
            if (tasks != null)
            {
                var id = tasks.Max(x => x.Id) + 1;
                task.SetId(id);
                tasks.Add(task);
                data = JsonConvert.SerializeObject(tasks);
            }
            else
            {
                task.SetId(1);
                data = JsonConvert.SerializeObject(task);
            }
            File.WriteAllText(DATA_PATH, data);
        }

        public void UpdateTask(TaskModel task)
        {
            var tasks = GetAllTasks();
            string data = string.Empty;
            if (tasks != null)
            {
                tasks[task.Id + 1] = task;
                data = JsonConvert.SerializeObject(tasks);
            }
            else
            {
                data = JsonConvert.SerializeObject(task);
            }
            File.WriteAllText(DATA_PATH, data);
        }

        public void DeleteTask(int id)
        {
            var tasks = GetAllTasks();
            var taskToDelete = GetTaskById(id);
            if (tasks != null && taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                var data = JsonConvert.SerializeObject(tasks);
                File.WriteAllText(DATA_PATH, data);
            }
            else if (tasks == null)
            {
                throw new Exception("The task list is empty.");
            }
            else if (taskToDelete == null)
            {
                throw new Exception("The task with this id does not exist.");
            }
        }
    }
}