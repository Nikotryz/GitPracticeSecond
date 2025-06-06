namespace GitPractice
{
    class GetPastTasksCommand
    {
        private readonly TaskHelper _taskHelper = new();

        public void GetPastTasks()
        {
            var tasks = _taskHelper.GetAllTasks();
            var pastTasks = tasks?.Where(x => x.Deadline < DateTime.Now);
            if (pastTasks == null)
            { 
                return; 
            }
            foreach (var task in pastTasks)
            {
                Console.WriteLine($"Task ID: {task.Id}\nTask name: {task.Name}\nTask description: {task.Description}\nTask deadline: {task.Deadline}");
            }
        }
    }
}
