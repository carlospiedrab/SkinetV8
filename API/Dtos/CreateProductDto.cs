using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CreateProductDto
    {
        [Required]
        public  string Name { get; set; } = string.Empty;
        [Required]
        public  string Description { get; set; }= string.Empty;
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }
        [Required]
        public string PictureUrl { get; set; }= string.Empty;
        public string Type { get; set; }= string.Empty;
        public string Brand { get; set; }= string.Empty;
        [Range(0.01, double.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int QuantityInStock { get; set; }
    }
}