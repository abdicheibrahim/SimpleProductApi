using SimpleProductApi.Models;
using SimpleProductApi.Services.Interfaces;
using SimpleProductApi.Data.UnitOfWork;

namespace SimpleProductApi.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
            return product;
        }

        public async Task<bool> UpdateAsync(int id, Product updatedProduct)
        {
            var existing = await _unitOfWork.Products.GetByIdAsync(id);
            if (existing == null) return false;

            existing.Name = updatedProduct.Name;
            existing.Description = updatedProduct.Description;
            existing.Price = updatedProduct.Price;

            _unitOfWork.Products.Update(existing);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _unitOfWork.Products.GetByIdAsync(id);
            if (existing == null) return false;

            _unitOfWork.Products.Remove(existing);
            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
