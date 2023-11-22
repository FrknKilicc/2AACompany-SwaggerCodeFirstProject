using System.ComponentModel.DataAnnotations;

namespace _2AACompany_SwaggerCodeFirstProject.Models
{
    public class Orderr
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderName { get; set; }


      
    }
}
