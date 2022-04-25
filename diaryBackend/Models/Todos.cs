namespace diaryBackend.Models
{
    public class Todos
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public int? EntryId { get; set; }

        public Todos()
        {
            //default constructor
        }

        public Todos(int id, string todo, int entryId)
        {
            Id = id;
            Todo = todo;
            EntryId = entryId;
        }
    }
}
