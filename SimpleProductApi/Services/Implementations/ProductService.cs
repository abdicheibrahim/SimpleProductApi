using SimpleProductApi.Models;
using SimpleProductApi.Services.Interfaces;
using SimpleProductApi.Data.UnitOfWork;
using AutoMapper;
using SimpleProductApi.DTOs;

namespace SimpleProductApi.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper= mapper;
        }

        //public async Task<IEnumerable<Product>> GetAllAsync()
        //{
        //    return await _unitOfWork.Products.GetAllAsync();
        //}

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var products = await _unitOfWork.Products.GetByIdAsync(id);
            return _mapper.Map<ProductDto?>(products);
        }

        //public async Task<ProductDto> CreateAsync(CreateProductDto dto)
        //{
        //    var products = await _unitOfWork.Products.AddAsync(dto);
        //    await _unitOfWork.SaveChangesAsync();
        //    return products;
        //}

        public async Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            var product = _mapper.Map<Product>(dto); // تحويل CreateProductDto إلى Product

            await _unitOfWork.Products.AddAsync(product); // إضافة المنتج
            await _unitOfWork.SaveChangesAsync();         // حفظ التغييرات

            return _mapper.Map<ProductDto>(product);      // تحويل الناتج إلى ProductDto
        }

        //public async Task<bool> UpdateAsync(int id, Product updatedProduct)
        //{
        //    var existing = await _unitOfWork.Products.GetByIdAsync(id);
        //    if (existing == null) return false;

        //    existing.Name = updatedProduct.Name;
        //    existing.Description = updatedProduct.Description;
        //    existing.Price = updatedProduct.Price;

        //    _unitOfWork.Products.Update(existing);
        //    await _unitOfWork.SaveChangesAsync();

        //    return true;
        //}
        public async Task<bool> UpdateAsync(int id, UpdateProductDto dto)
        {
            var existing = await _unitOfWork.Products.GetByIdAsync(id);
            if (existing == null) return false;

            _mapper.Map(dto, existing);

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
