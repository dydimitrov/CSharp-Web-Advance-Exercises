using Chuska.Models.ViewModels.Product;
using System.Collections.Generic;

namespace Chuska.Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductListViewModel> GetAllProducts();

        void Create(string name,
                           decimal price,
                           string description,
                           string productType);

        ProductEditViewModel FindById(int id);

        void EditById(ProductEditViewModel model, int id);

        void DeleteById(int id);

        void Order(int id, string username);
    }
}
