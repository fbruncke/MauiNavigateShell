using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNavigateShell.Model
{
    public class Item : BindableObject
    {
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
