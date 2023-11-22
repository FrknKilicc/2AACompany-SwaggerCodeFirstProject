using _2AACompany_SwaggerCodeFirstProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _2AACompany_SwaggerCodeFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly ApplicationDbContext context;
        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("GetOrder")]
        public async Task<IEnumerable<Orderr>> GetOrder()
        {
            return await context.Orders.ToListAsync();

        }
        [HttpPost]
        [Route("AddOrder")]
        public async Task<Orderr> AddOrder(Orderr order)
        {
            await context.Orders.AddAsync(order);
            context.SaveChanges();
            return order;
        }
        [HttpPut]
        [Route("UpdateOrder/{id}")]
        public async Task<Orderr> UpdateOrder(Orderr orderr)

        {
            context.Orders.Update(orderr);
            await context.SaveChangesAsync();

            return orderr;
        }
        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public bool DeleteOrder(int id)
        {
            bool transactionss = false;
            var findid = context.Orders.FirstOrDefault(x => x.OrderId == id);
            if (findid != null)
            {
                transactionss = true;
                context.Remove(findid);
                context.SaveChanges();

            }
            else
            {
                return false;
            }
            return transactionss;

        }

    }
}
