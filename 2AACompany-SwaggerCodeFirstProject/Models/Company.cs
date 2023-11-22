using System.ComponentModel.DataAnnotations;

namespace _2AACompany_SwaggerCodeFirstProject.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string? Name { get; set; }
        public string Country { get; set; }
       

    }
}
