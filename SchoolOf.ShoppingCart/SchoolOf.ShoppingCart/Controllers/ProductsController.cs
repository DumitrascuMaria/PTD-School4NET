using Microsoft.AspNetCore.Mvc;
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
        //returneaza o lista de produse statice
        [HttpGet] //verbe pt a initia un request http
        [ProducesResponseType(typeof(IEnumerable<ShoolOf.Dtos.ProductDto>),200)]
        public async Task<IActionResult> getProducts()
        {
            //iactionresult=returneaza o lista mai ampla de modele
            //async=thread-ul care a pornit procesarea se intoarce in threadpool, comunicare asincrona
            var mylistofPtoducts = new List<ShoolOf.Dtos.ProductDto>();
            mylistofPtoducts.Add(new ShoolOf.Dtos.ProductDto
            {
                Category = "test category",
                Description = " test description",
                Id = 10,
                Image="no image yet",
                Name="test product",
                Price=100
            }) ;
            return Ok(mylistofPtoducts); //(sau not found) ok= returneaza un hhtp status 200
            
            
        }
             
    }
}
