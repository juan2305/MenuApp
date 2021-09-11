using MenuApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MenuApp.ViewModel
{
    
    public class MenuViewModel : INotifyPropertyChanged
    {
        public MenuItem Item1 { get; }
        public MenuItem Item2 { get; }
        public MenuItem Item3 { get; }
        public MenuItem Item4 { get; }
        public MenuItem Item5 { get; }
        public MenuItem Item6 { get; }

        public MenuViewModel()
        {
            Item1 = new MenuItem("Bread", "bread.png", "Breakfast");
            Item2 = new MenuItem("Burger", "burger.png", "Dinner");
            Item3 = new MenuItem("IceTea", "icecream.png", "Drinks");
            Item4 = new MenuItem("Salad", "diet.png", "Dinner");
            Item5 = new MenuItem("Juice", "juice.png", "Drinks");
            Item6 = new MenuItem("Pizza", "pizza.png", "Lunch");

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
