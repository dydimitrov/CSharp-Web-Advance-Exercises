using IRunesAplication.Data.Models;
using System.Collections.Generic;

namespace IRunesAplication.ViewModels.Product
{
    public class ProductListingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
