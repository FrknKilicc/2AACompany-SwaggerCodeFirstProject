using _2AACompany_SwaggerCodeFirstProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;

namespace _2AACompany_SwaggerCodeFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ApplicationDbContext Context;
        public CustomerController(ApplicationDbContext context)
        {
            Context = context;
        }
        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IEnumerable<Customer>> GetCustomer()
        {

            return await Context.Customers.ToListAsync();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public async Task<Customer> AddCustomer(Customer customer)
        {
            Context.Customers.Add(customer);
            await Context.SaveChangesAsync();
            return customer;
        }
        [HttpPut]
        [Route("UpdateCustomer/{id}")]
        public async Task<Customer> UpdateCustomer(Customer customer)
        {

            Context.Update(customer);
            Context.SaveChanges();
            return customer;
        }
        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public bool DeleteCustomer(int id)
        {
            bool transactionss = false;
            var findid = Context.Customers.FirstOrDefault(x => x.CustomerId == id);
            if (findid != null)
            {
                transactionss = true;
                Context.Remove(findid);
                Context.SaveChanges();

            }
            else
            {
                return false;
            }

            return transactionss;


        }
    }
}
