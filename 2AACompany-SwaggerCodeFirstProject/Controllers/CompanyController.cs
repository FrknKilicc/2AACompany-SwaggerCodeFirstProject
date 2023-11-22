using _2AACompany_SwaggerCodeFirstProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata;

namespace _2AACompany_SwaggerCodeFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public readonly ApplicationDbContext context;
        public CompanyController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        [Route("Index")]
        public async Task<IEnumerable<Company>> Index()
        {
            return await context.Companys.ToListAsync();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<Company> Create(Company company)
        {
            await context.AddAsync(company);
            await context.SaveChangesAsync();
            return company;
        }
        [HttpPut]
        [Route("UpdateCompany/{id}")]
        public async Task<Company> UpdateCompany(Company company)
        {
            context.Update(company);
            await context.SaveChangesAsync();
            return company;
        }
        [HttpDelete]
        [Route("DeleteCompany/{id}")]

        public bool DeleteCompany(int id)
        {
            bool transactionss = false;
            var findid = context.Companys.Find(id);
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
