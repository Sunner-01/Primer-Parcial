using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        // Clave Primaria (PK)
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; } 

        [Required]
        public string Instructions { get; set; } 

        public int PreparationTimeMinutes { get; set; }

        public int Servings { get; set; } 

        public DateTime DateCreated { get; set; } 

        // --- Relaciones de Entity Framework Core ---

        // Clave Foránea (FK): Vincula esta receta a una categoría
        public int CategoryId { get; set; }

        // Propiedad de Navegación: El lado 'uno' para la Categoría
        public Category Category { get; set; }

        // Propiedad de Navegación: El lado 'muchos' para los Ingredientes
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
