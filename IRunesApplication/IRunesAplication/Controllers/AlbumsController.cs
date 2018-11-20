namespace IRunesAplication.Controllers
{
    using SimpleMvc.Framework.Contracts;
    using IRunesAplication.Services.Contracts;
    using IRunesAplication.Services;
    using System.Text;
    using System.Linq;
    using SimpleMvc.Framework.Attributes.Methods;
    using IRunesAplication.ViewModels.Product;

    public class AlbumsController : BaseController
    {

        private readonly IProductService albums;
        public AlbumsController()
        {
            this.albums = new ProductService();
        }

        public IActionResult All()
        {
            var listOfAlbums = albums.All().ToList();

            var sb = new StringBuilder();
            sb.AppendLine("<div>");

            foreach (var item in listOfAlbums)
            {
                sb.AppendLine($@"<p><a href=""/Albums/Details?id={item.Id}"">{item.Name}</a></p>");
            }
            sb.AppendLine("</div>");

            this.ViewModel["anonymousUser"] = "none";
            this.ViewModel["loggedUser"] = "block";
            this.ViewModel["albumsContent"] = sb.ToString();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(AddProductViewModel model)
        {
            albums.Create(model.Name, model.Url);
            return this.All();
        }

        public IActionResult Details(int id)
        {
            var album = albums.Find(id);

            this.ViewModel["album-id"] = $"{id}";
            this.ViewModel["image-url"] = album.ImageUrl;
            this.ViewModel["album-name"] = album.Name;
            this.ViewModel["album-price"] = $"{album.Price:f2}";

            if (album.Tracks.Count != 0)
            {
                this.ViewModel["tracks"] = "block";
                var sb = new StringBuilder();
                foreach (var track in album.Tracks)
                {
                    sb.AppendLine($@"<li><a href=""/Tracks/Details?albumId={id}&trackId={track.Id}"">{track.Name}</a></li>");
                }
                this.ViewModel["content-album"] = sb.ToString();
            }
            else
            {
                this.ViewModel["content-album"] = "none";
            }
            return View();
        }
    }
}