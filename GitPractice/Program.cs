namespace GitPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВведите команду\n[add] - добавить задачу\n[delete] - удалить задачу\n[edit] - отредактировать задачу\n[view all] - просмотреть все задачи\n[view past] - просмотреть прошедшие задачи\n[view upcoming] - просмотреть предстоящие задачи\n[view today] - просмотреть задачи на сегодня\n[exit] - выйти из программы");
                string command = Console.ReadLine();
                var taskHelper = new TaskHelper();
                Console.Clear();
                if (command == "add")
                {
                    Console.Write("Введите название задачи: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите описание задачи: ");
                    string description = Console.ReadLine();
                    Console.Write("До какого числа нужно сделать? (ГГГГ-ММ-ДД): ");
                    string deadline = Console.ReadLine();
                    TaskModel task = new TaskModel(title, description, deadline);
                    taskHelper.CreateTask(task);
                    Console.WriteLine("Задача была сохранена");
                    continue;
                }
                if (command == "delete")
                {
                    Console.Write("Какую задачу удалить? (Введите её ID): ");
                    int idToRemove = int.Parse(Console.ReadLine());
                    try
                    {
                        taskHelper.DeleteTask(idToRemove);
}
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    continue;
                }
                if (command == "view all")
                {
                    var action = new GetAllTasksCommand();
                    action.GetAllTasks();
                    continue;
                }
                if (command == "view past")
                {
                    var action = new GetPastTasksCommand();
                    action.GetPastTasks();
                    continue;
                }
                if (command == "view upcoming")
                {
                    var action = new GetUpcomingTasksCommand();
                    action.GetUpcomingTasks();
                    continue;
                }
                if (command == "view today")
                {
                    var action = new GetTodayTasksCommand();
                    action.GetTodayTasks();
                    continue;
                }
                if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}