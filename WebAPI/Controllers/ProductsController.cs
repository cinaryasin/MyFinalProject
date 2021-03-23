using Business.Abstract;
using Business.ConCrete;
using DataAccess.ConCrete.EntityFramework;
using Entities.ConCrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //IoC Container  Inversion of Control - bellekte tanımlanmış newlenmiş bi alandan çekme
        //loosely coupled  gevşek bağlılık.
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency Resolvers  bağımlılık çözümleyici
            //Dependency chain Bağımlılık servisi var yanlış kod
            //IProductService productService = new ProductManager(new EfProductDal());
           //Thread.Sleep(500);

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result); // . Data alabiliriz
            }
            return BadRequest(result); // .message alabiliriz

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //mesaj için kullanılan komut
        //public string Get()
        //{

        //    IProductService productService = new ProductManager(new EfProductDal());
        //    var result = productService.GetAll();
        //    return result.Message;

        //}


    }
}
