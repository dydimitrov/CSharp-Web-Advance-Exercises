namespace Torshia.Models
{
    using System;
    using System.Collections.Generic;
    public class Task
    {
        //•	Has an Id – a GUID String or an Integer.
        //•	Has a Title
        //•	Has a Due Date – a Date object (by default – false).
        //•	Has a IsReported – a boolean.
        //•	Has a Description
        //•	Has Participants – (entered as comma separated string values... You can store them however you want)
        //•	Has Affected Sectors – a collection which may contain 1 or more of the following values(“Customers”, “Marketing”, “Finances”, “Internal”, “Management”)

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsReported { get; set; } = false;

        public string Description { get; set; }

        public string Participants { get; set; }

        public ICollection<TasksSectors> AffectedSectors { get; set; } = new HashSet<TasksSectors>();
    }
}
