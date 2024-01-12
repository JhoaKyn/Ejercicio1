using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models; 
using TodoApi.Repositories;

namespace Todoapi.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private ProductDummyRepository productRepository;


        public ProductsController() //Constructor
        {
            this.productRepository =new ProductDummyRepository();
        }

        [HttpGet]
        public List<Product> Get()
        {
           List<Product> products = this.productRepository.GetAll();     
           return products;
        }
         
         [HttpGet("{id}")]
         public Product Get(int id)
        {
            Product product = this.productRepository.FindById(id);
            return product;
        }
        
         [HttpPost]
        public Product Post(Product product)
        { 
            //llamar a la BD para crear producto 
            return product;
        }

        [HttpPut("{id}")]
        public Product Put(Product product, int id)
        {
            //insert
            return product;    
        } 

        [HttpDelete]
        public int Delete(int id)
        {
            return id;
        }
        
        
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "values";
        //}

       
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //} 
         
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }

   





