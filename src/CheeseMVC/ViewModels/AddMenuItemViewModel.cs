using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        //variables for the display of data in form
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        //variables for processing of form data
        public int MenuID { get; set; }
        public int CheeseID { get; set; }

        //default constructor for model binding
        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {
            Cheeses = new List<SelectListItem>();

            //building the select form field with all the available cheeses in the db
            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                    {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                    });
            }

            Menu = menu;

        }
    }
}
