using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubAsp.Models
{
    public class GreenBean
    {
        public int Id { get; set; }

        [Required, DisplayName("Bin Number")]
        [Range(1, 100)]
        public int BinNo { get; set; }

        [Required, DisplayName("Class")]
        [Range(100, 999999)]
        public int GreenClass { get; set; }

        [Required, DisplayName("Lot Number")]
        [Range(100, 999999)]
        public int LotNumber { get; set; }

        [Required, DisplayName("Bin Level")]
        [Column(TypeName = "decimal(6, 1)")]
        public decimal BinLevel { get; set; }
    }
}
