using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using burgers.Interfaces;

namespace burger.Models
{
    public class Item : IItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //By default this has a parameterless contructor
    }
}