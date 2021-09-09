using ErickEspinosa.AbstractFactory.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErickEspinosa.AbstractFactory.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IAbstractFactory _abstractFactory;
        public ProductsController(IAbstractFactory abstractFactory)
        => _abstractFactory = abstractFactory;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                sofa = _abstractFactory.CreateSofa(),
                chair = _abstractFactory.CreateChair(),
                coffetable = _abstractFactory.CreateCoffeTable()
            });
        }
    }
}
