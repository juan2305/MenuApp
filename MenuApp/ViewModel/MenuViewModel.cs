using MenuApp.Models;
using MenuApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Input;


namespace MenuApp.ViewModel
{
      
    public class MenuViewModel : INotifyPropertyChanged
    {

        Xamarin.Forms.Frame frame = new Xamarin.Forms.Frame();
        public event PropertyChangedEventHandler PropertyChanged;
        public MenuItem Item1 { get; }
        public MenuItem Item2 { get; }
        public MenuItem Item3 { get; }
        public MenuItem Item4 { get; }
        public MenuItem Item5 { get; }
        public MenuItem Item6 { get; }
        public ICommand TapFrame { get; set; }
        public MenuViewModel()
        {

            TapFrame = new Xamarin.Forms.Command(Tap);
            Item1 = new MenuItem("Bread", "bread.png", "Breakfast");
            Item2 = new MenuItem("Burger", "burger.png", "Dinner");
            Item3 = new MenuItem("IceTea", "icecream.png", "Drinks");
            Item4 = new MenuItem("Salad", "diet.png", "Dinner");
            Item5 = new MenuItem("Juice", "juice.png", "Drinks");
            Item6 = new MenuItem("Pizza", "pizza.png", "Lunch");
        }
        private void Tap (object sender)
        {
            frame.BackgroundColor = Color.White;
            var element = sender as Xamarin.Forms.Frame;
            element.BackgroundColor = Color.LightYellow;
            frame = element;
        }

       

    }

}
