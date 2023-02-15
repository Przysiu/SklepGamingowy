using System.Collections.Generic;
using SklepGamingowy.Models;

namespace SklepGamingowy.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; } 
    }
}
