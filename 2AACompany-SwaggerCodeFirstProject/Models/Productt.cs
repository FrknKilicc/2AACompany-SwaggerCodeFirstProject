using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2AACompany_SwaggerCodeFirstProject.Models
{
    public class Productt
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Orderr Order { get; set; }
    }
}
