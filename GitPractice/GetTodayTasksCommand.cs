namespace GitPractice
{
    class GetTodayTasksCommand
    {
        private readonly TaskHelper _taskHelper = new();

        public void GetTodayTasks()
        {
            var tasks = _taskHelper.GetAllTasks();
            var todayTasks = tasks?.Where(x => x.Deadline == DateTime.Today);
            if (todayTasks == null)
            { 
                return; 
            }
            foreach (var task in todayTasks)
            {
                Console.WriteLine($"Task ID: {task.Id}\nTask name: {task.Name}\nTask description: {task.Description}\nTask deadline: {task.Deadline}");
            }
        }
    }
}
