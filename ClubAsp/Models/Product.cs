using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubAsp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, DisplayName("Product Code")]
        [StringLength(10)]
        public string ProductCode { get; set; }

        [Required, DisplayName("Product Description")]
        [StringLength(60)]
        public string ProductDescription { get; set; }

        [Required, DisplayName("Blend Number")]
        [StringLength(10)]
        public string BlendNumber { get; set; }

        [Required, DisplayName("Blend Description")]
        [StringLength(60)]
        public string BlendDescription { get; set; }

        [Required, DisplayName("Pack Weight")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PackWeight { get; set; }

        [Required, DisplayName("Declared Weight")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal DeclaredWeight { get; set; }

        [Required, DisplayName("Color Range")]
        [StringLength(60)]
        public string ColorRange { get; set; }
    }
}
