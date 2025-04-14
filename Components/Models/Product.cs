using System.ComponentModel.DataAnnotations;

namespace BlazorLearningPOC.Components.Model
{
    public class Product
    {
        public Product()
        {
            AvailableAfter = DateOnly.FromDateTime(DateTime.Now);
        }
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<ProductProp> ProductProperties { get; set; }

        public Category Category { get; set; }
        public DateOnly AvailableAfter { get; set; }

    }

    public enum Category
    {
        Entree,
        Appetizer,
        Dessert
    }

}
