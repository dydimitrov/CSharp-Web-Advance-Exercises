namespace IRunesAplication.ViewModels.Product
{
    using System.Collections.Generic;
    using System.Linq;

    public class ProductDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Price
        {
            get
            {
                return this.Tracks.Sum(t => t.Price);
            }
        }

        public string ImageUrl { get; set; }

        public List<TrackViewModel> Tracks { get; set; } = new List<TrackViewModel>();
    }
}
