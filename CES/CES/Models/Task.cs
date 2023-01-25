namespace CES.Models
{
    public class Task : AuditInfo
    {
        public int Id { get; set; }

        public string? AuthorCode { get; set; }

        public string Language { get; set; }

        public int TimeLimitSeconds { get; set; }

        public int MemoryLimitMegabytes { get; set; }

        public ICollection<Submission> Submissions { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}
