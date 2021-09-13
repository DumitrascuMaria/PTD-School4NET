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
    [ApiController] 
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrdersController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        
        [HttpGet] 
        [ProducesResponseType(typeof(IEnumerable<OrderDto>), 200)]
        public async Task<IActionResult> GetOrders()
        {
           
            var myListOfOrders = new List<OrderDto>();
            var ordersFromDb = this._unitOfWork.GetRepository<Order>().Find(product => !product.IsDeleted);

            foreach (var o in ordersFromDb)
            {
                myListOfOrders.Add(new OrderDto
                {
                    
                    Id = o.Id,
                    Name = o.Name,
                    Address=o.Address,
                    Email=o.Email,
                    PhoneNo=o.PhoneNo,
                    Total=o.Total
                   
                });
            }


            return Ok(myListOfOrders); 


        }
    }
}
