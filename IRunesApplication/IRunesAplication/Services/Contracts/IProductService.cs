namespace IRunesAplication.Services.Contracts
{
    using IRunesAplication.ViewModels.Product;
    using System.Collections.Generic;
    public interface IProductService
    {
        void Create(string name, string imageUrl);

        IEnumerable<ProductListingViewModel> All(string searchTerm = null);

        ProductDetailsViewModel Find(int id);
    }
}
