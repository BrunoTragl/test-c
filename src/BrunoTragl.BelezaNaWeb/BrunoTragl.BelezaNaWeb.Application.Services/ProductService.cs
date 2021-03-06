﻿using BrunoTragl.BelezaNaWeb.Application.Services.Interfaces;
using BrunoTragl.BelezaNaWeb.Domain.Model;
using BrunoTragl.BelezaNaWeb.Domain.Repository.Interfaces;
using System;

namespace BrunoTragl.BelezaNaWeb.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IInventoryService _inventoryService;
        public ProductService(IProductRepository productRepository,
                              IInventoryService inventoryService)
        {
            _productRepository = productRepository;
            _inventoryService = inventoryService;
        }
        public Product Get(long sku)
        {
            try
            {
                return _productRepository.Get(sku);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Any(long sku)
        {
            try
            {
                return _productRepository.Any(sku);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Add(Product product)
        {
            try
            {
                _productRepository.Add(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Product product)
        {
            try
            {
                _productRepository.Update(product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Remove(long sku)
        {
            try
            {
                _productRepository.Remove(sku);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool IsMarketable(long sku)
        {
            try
            {
                uint quantity = _inventoryService.CalculateInventory(sku);
                return quantity > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
