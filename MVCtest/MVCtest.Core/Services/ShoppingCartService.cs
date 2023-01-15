using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCtest.Core.Contracts;
using MVCtest.Core.Models;
using MVCtest.Infrastructure.Common;
using MVCtest.Infrastructure.Models;

namespace MVCtest.Core.Servises
{
    public class ShoppingCartService : IShoppingCartService
    {

        private readonly UnitOfWork _unitOfWork;
        private readonly Product _product;

        public ShoppingCartService(UnitOfWork unitOfWork, Product product)
        {
            _unitOfWork = unitOfWork;
            _product = product;
        }
        public async Task<ShoppingCart> GetShoppingCartAsyncById(int id)
        {
            ShoppingCart shoppingCart = new()
            {
                ProductVModel = new()
                {
                    Product = new(),
                    CategoryList = _unitOfWork.Category.GetAll()
                        .Where(c => c.isDeleted == false)
                        .Select(c => new SelectListItem
                        {
                            Text = c.Name,
                            Value = c.Id.ToString()

                        }),
                    CoverTypeList = _unitOfWork.Cover.GetAll()
                        .Where(c => c.isDeleted == false)
                        .Select(c => new SelectListItem
                        {
                            Text = c.Name,
                            Value = c.Id.ToString()

                        })
                },
                Count = 1
            };
            shoppingCart.ProductVModel.Product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id,
                includeProperties: "Category,Cover");
            if (shoppingCart == null)
            {
                throw new ArgumentException("Something is wrong!");
            }

            return shoppingCart;

        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = _unitOfWork.Product.GetAll(includeProperties: "Category,Cover")
                .Where(c => c.isDeleted == false)
                .Select(c => new Product()
                {
                    Id = c.Id,
                    Title = c.Title,
                    ISBN = c.ISBN,
                    Price = c.Price,
                    Author = c.Author,
                    CoverId = c.CoverId,
                    Cover = c.Cover,
                    CategoryId = c.CategoryId,
                    Category = c.Category
                }).ToList();
            return products;
        }


        /*public async <s> 

        ShoppingCart _shoppingCart = new()
        {
            ProductVModel = new()
            {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll()
                    .Where(c => c.isDeleted == false)
                    .Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()

                    }),
                CoverTypeList = _unitOfWork.Cover.GetAll()
                    .Where(c => c.isDeleted == false)
                    .Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()

                    })
            },
            Count = 1
        };
        shoppingCart.ProductVModel.Product = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id,
        includeProperties: "Category,Cover");
        if (shoppingCart == null)
        {
            return NotFound();
        }
        return View(shoppingCart.ProductVModel);*/

    }
}
