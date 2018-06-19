using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //a menu consists of a list of relationships to cheeses, not a list of cheeses themselves
        public IList<CheeseMenu> CheeseMenus = new List<CheeseMenu>();
    }
}
