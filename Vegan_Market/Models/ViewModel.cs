using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vegan_Market.Models
{
    public class ViewModel
    {
        public IEnumerable<Sub_Category> Subcategori { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}