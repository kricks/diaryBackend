namespace diaryBackend.Models
{
    public class Todos
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public int? EntryId { get; set; }
    }
}
