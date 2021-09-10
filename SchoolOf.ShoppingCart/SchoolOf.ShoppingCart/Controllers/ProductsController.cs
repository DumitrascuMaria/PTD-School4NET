using Microsoft.AspNetCore.Mvc;
using SchoolOf.Data.Abstraction;
using SchoolOf.Data.Models;
using ShoolOf.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOf.ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //este un controller API nu avem view
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        //returneaza o lista de produse statice
        [HttpGet] //verbe pt a initia un request http
        [ProducesResponseType(typeof(IEnumerable<ShoolOf.Dtos.ProductDto>),200)]
        public async Task<IActionResult> GetProducts()
        {
            //iactionresult=returneaza o lista mai ampla de modele
            //async=thread-ul care a pornit procesarea se intoarce in threadpool, comunicare asincrona
            var myListOfProducts = new List<ShoolOf.Dtos.ProductDto>();
            var productsFromDb = this._unitOfWork.GetRepository<Product>().Find(product => !product.IsDeleted);

            foreach (var p in productsFromDb)
            {
                myListOfProducts.Add(new ProductDto
                {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    Image = p.Image,
                    Name = p.Name,
                    Price = p.Price
                });
            }


            return Ok(myListOfProducts); //(sau not found) ok= returneaza un hhtp status 200
            
            
        }
             
    }
}
