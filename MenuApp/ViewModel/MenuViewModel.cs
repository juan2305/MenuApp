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
            Item1 = new MenuItem("Bread", "bread.png", "Desayuno");
            Item2 = new MenuItem("Burger", "burger.png", "Cena");
            Item3 = new MenuItem("Icecream", "icecream.png", "Bebida");
            Item4 = new MenuItem("Salad", "diet.png", "Cena");
            Item5 = new MenuItem("Juice", "juice.png", "Bebida");
            Item6 = new MenuItem("Pizza", "pizza.png", "Almuerzo");

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
