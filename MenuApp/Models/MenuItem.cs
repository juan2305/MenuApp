using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp.Models
{
   public class MenuItem
    {
        public MenuItem(string title, string image, string detail)
        {
            Title = title;
            Image = image;
            Detail = detail;
        }
        public string Title { get; }
        public string Image { get; }
        public string Detail { get; }
        
    }
}
