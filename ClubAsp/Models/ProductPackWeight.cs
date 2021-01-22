using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ClubAsp.Models
{
    public class ProductPackWeight
    {
        public List<Product> Products { get; set; }
        public SelectList PackWt { get; set; }
        public decimal ProductPackWt { get; set; }
        public string SearchString { get; set; }
        public string ColorRange { get; set; }
    }
}
