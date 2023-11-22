using _2AACompany_SwaggerCodeFirstProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2AACompany_SwaggerCodeFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly ApplicationDbContext Context;
        public ProductsController(ApplicationDbContext Context)
        {
            this.Context = Context;
        }
        [HttpGet]
        [Route("GetProducts")]
        public async Task<IEnumerable<Productt>> GetProducts()
        {
            return await Context.Products.ToListAsync();
        }
        [HttpPost]
        [Route("AddProducts")]
        public async Task<Productt> AddProducts(Productt products)
        {
            await Context.Products.AddAsync(products);
            await Context.SaveChangesAsync();
            return products;
        }
        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public async Task<Productt> UpdateProducts(Productt products)
        {
            Context.Products.Update(products);
            await Context.SaveChangesAsync();
            return products;

        }
        [HttpDelete]
        [Route("DeleteProducts/{id}")]
        public bool DeleteProducts(int id)
        {
            bool transactionnsss = false;
            var findid = Context.Products.Find(id);
            if (findid != null)
            {
                transactionnsss = true;
                Context.Remove(findid);
                Context.SaveChanges();

            }
            else
            {
                return false;
            }
            return transactionnsss;
        }

    }
}
