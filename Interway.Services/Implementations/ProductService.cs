using AutoMapper;
using InterwayAPI.DataAccess.Implementations;
using InterwayAPI.DataAccess.Interfaces;
using InterwayAPI.Domain.Entities;
using InterwayAPI.Services.Interfaces;
using InterwayAPI.ViewModels.Enums;
using InterwayAPI.ViewModels.Models;
using System.Collections.Generic;

namespace InterwayAPI.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductViewModel> GetAllProducts()
        {
            var products = _productRepository.GetAll();
            var mappedProducts = _mapper.Map<List<ProductViewModel>>(products);
            return mappedProducts;
        }

        public List<ProductViewModel> GetAllFeaturedProducts()
        {
            var featuredProducts = _productRepository.GetAllFeaturedProducts();
            var mappedProducts = _mapper.Map<List<ProductViewModel>>(featuredProducts);
            return mappedProducts;
        }

        public ProductViewModel GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        public PagedResultViewModel<ProductViewModel> GetFilteredProducts(ProductsDatatableRequestViewModel productsDatatableRequestViewModel)
        {
            var searchValue = productsDatatableRequestViewModel.search.value ?? string.Empty;
            var productsPagedResult = _productRepository.GetFilteredProducts(productsDatatableRequestViewModel.CategoryId,
                                                                             productsDatatableRequestViewModel.start,
                                                                             productsDatatableRequestViewModel.length,
                                                                             searchValue,
                                                                             productsDatatableRequestViewModel.sortColumn,
                                                                             productsDatatableRequestViewModel.isAscending);
            return _mapper.Map<PagedResultViewModel<ProductViewModel>>(productsPagedResult);
        }

        public void CreateProduct(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            int productId = _productRepository.Insert(product);
            if(productId <= 0)
            {
                throw new Exception($"Something went wrong while saving the new product");
            }
        }

        public void UpdateProduct(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<Product>(productViewModel);
            _productRepository.Update(product);
        }

        public void DeleteProductById(int id)
        {
            _productRepository.DeleteById(id);
        }
    }
}
