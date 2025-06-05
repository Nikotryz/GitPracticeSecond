namespace GitPractice
{
    public class TaskModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Deadline { get; private set; }

        public TaskModel(string name, string description, string deadline)
        {
            Name = name;
            Description = description;
            Deadline = DateTime.Parse(deadline);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetDeadline(string deadline)
        {
            Deadline = DateTime.Parse(deadline);
        }
    }
}
