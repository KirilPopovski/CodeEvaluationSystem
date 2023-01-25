namespace CES.Models
{
    public class Submission : AuditInfo
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
