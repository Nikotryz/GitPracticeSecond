namespace GitPractice
{
    class GetAllTasksCommand
    {
        private readonly TaskHelper _taskHelper = new();

        public void GetAllTasks()
        {
            var tasks = _taskHelper.GetAllTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task ID: {task.Id}\nTask name: {task.Name}\nTask description: {task.Description}\nTask deadline: {task.Deadline}");
            }
        }
    }
}
