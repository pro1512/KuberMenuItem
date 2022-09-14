using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemsListingAPI.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool FreeDelivery { get; set; }
        [Required]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DateOfLaunch { get; set; }
        public bool Active { get; set; }

    }
}
