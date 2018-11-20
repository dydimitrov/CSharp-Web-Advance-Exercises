using IRunesAplication.Services;
using IRunesAplication.Services.Contracts;
using IRunesAplication.ViewModels.Product;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Contracts;

namespace IRunesAplication.Controllers
{
    public class TracksController : BaseController
    {
        private readonly ITrackService tracks;
        private readonly IProductService products;

        public TracksController()
        {
            this.tracks = new TrackService();
            this.products = new ProductService();
        }
        public IActionResult Create()
        {
            this.ViewModel["album-id"] = this.Request.UrlParameters["Id"].ToString();

            return View();
        }
        [HttpPost]
        public IActionResult Create(AddTrackViewModel model, int Id)
        {
            this.ViewModel["album-id"] = Id.ToString();
            var price = decimal.Parse(model.Price);
            this.tracks.Create(model.Name, model.Link, price, Id);
            return View();
        }

        public IActionResult Details(int albumId, int trackId)
        {
             var track = this.tracks.Find(trackId, albumId);
            this.ViewModel["trackTitleDetails"] = track.Name;
            this.ViewModel["trackPriceDetails"] = $"{track.Price:F2}";
            var linkId = track.videoLink.Substring(track.videoLink.Length - 11);
            var linkPath = $@"https://www.youtube.com/embed/{linkId}?autoplay=1";
            this.ViewModel["trackUrl"] = linkPath;
            this.ViewModel["albumPathHolder"] = track.AlbumId.ToString();

            return View();
        }
    }
}