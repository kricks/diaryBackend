using System.Text.Json.Serialization;

namespace diaryBackend.Models
{
    public class Entries
    {
        public int Id { get; set; }
        public string Entry { get; set; }
        public string Date { get; set; }

        [JsonConstructor]
        public Entries ()
        {
            // default constructor
        }
        public Entries(int id, string entry, string date)
        {
            Id = id;
            Entry = entry; 
            Date = date;
        }
    }
}
