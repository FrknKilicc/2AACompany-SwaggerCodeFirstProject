using System.ComponentModel.DataAnnotations;

namespace _2AACompany_SwaggerCodeFirstProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        

    }
}
