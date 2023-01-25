namespace CES.Models
{
    public class Submission : AuditInfo
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Language { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

        public string CreatedBy { get; set; }

        public ApplicationUser Creator { get; set; }
    }
}
