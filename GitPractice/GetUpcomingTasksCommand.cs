namespace GitPractice
{
    class GetUpcomingTasksCommand
    {
        private readonly TaskHelper _taskHelper = new();

        public void GetUpcomingTasks()
        {
            var tasks = _taskHelper.GetAllTasks();
            var upcomingTasks = tasks?.Where(x => x.Deadline > DateTime.Now);
            if (upcomingTasks == null)
            { 
                return; 
            }
            foreach (var task in upcomingTasks)
            {
                Console.WriteLine($"Task ID: {task.Id}\nTask name: {task.Name}\nTask description: {task.Description}\nTask deadline: {task.Deadline}");
            }
        }
    }
}
