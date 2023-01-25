namespace CES.Models
{
    public class Test
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string? Input { get; set; }

        public string? ExpectedOutput { get; set; }

        public string? RealOutput { get; set; }

        public bool IsVisible { get; set; }

        public string MethodName { get; set; }

        public string MethodParameters { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }
    }
}
