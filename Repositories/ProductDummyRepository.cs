using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Repositories;

    public class ProductDummyRepository
    {
      private List<Product> listProducts;
       public List<Product> GetAll()
       {
        return new List<Product>();
       } 
      
      //Antigua Forma 
      //Product product1 = new Product();
      //product.Id = 1;
      //product.Name ="Algo 1";

      //Product product2 = new Product();
      //{
      //   Id =2;
      //   Name = "Algo 2"
      //}
      //ListProducts.Add(product1);
      //ListProducts.Add(product2);


      //Nueva forma de añadir 
       public ProductDummyRepository()
       {
        listProducts = new List<Product>();
         
         listProducts.Add(new Product(){
         Id = 1,
         Name = "Algo"
         });

         listProducts.Add(new Product(){
         Id = 2,
         Name = "Algo 2"
         });

         listProducts.Add(new Product(){
         Id = 3,
         Name = "Algo 3"
         });
       }

       public Product FindById(int id)
       {//logica para buscar 
         foreach (Product product in listProducts)
         {
          if (product.Id == id)
          {
            return product;
          }
         }
          return new Product();

       }

       public Product Create(Product product)
       {
        return new Product();
       }

       public Product Update(Product product, int id)
       {
        return product;
       }

       public int Remove(int id)
       {
        return id;
       }
    }
