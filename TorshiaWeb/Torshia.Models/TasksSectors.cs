namespace Torshia.Models
{
    using Enums;
    public class TasksSectors
    {
        public int Id { get; set; }

        public Task Task { get; set; }
        public int TaskId { get; set; }

        public Sectors Sectors { get; set; }
    }
}
