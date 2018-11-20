namespace IRunesAplication.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    public class Album
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Cover { get; set; }

        [NotMapped]
        public decimal? Price
        {
            get
            {
                return this.Tracks.Sum(t => t.Price);
            }
        }

        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
