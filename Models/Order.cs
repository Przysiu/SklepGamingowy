using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SklepGamingowy.Models
{

    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Imię i Nazwisko Gamingowca")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Adres Gamingowca")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Miasto Gamingowca")]
        public string City { get; set; }

        [Required(ErrorMessage = "Województwo Gamingowca")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Kraj Gamingowca")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
    }
}

