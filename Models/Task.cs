namespace ToDoList.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
        public bool Deleted { get; set; }
        public Task()
        {

        }
        public Task(int id, string name, bool done, bool deleted)
        {
            Id = id;
            Name = name;
            Done = done;
            Deleted = deleted;

        }
    }

}