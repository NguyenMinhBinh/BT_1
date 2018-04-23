using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace B2.Class
{
    public class MenuViewModel
    {

        public class MenuItem
        {
            public string icon { get; set; }
            public string Title { get; set; }
        }
        public List<MenuItem> Menu { get ; set ; }

        public MenuViewModel()
        {
             Menu=new List<MenuItem>
            {
                new MenuItem {icon="icon.png", Title="Menu 1"},
                new MenuItem {icon="icon.png", Title="Menu 2"},
                new MenuItem {icon="icon.png", Title="Menu 3"},
                new MenuItem {icon="icon.png", Title="Menu 4"},
                new MenuItem {icon="icon.png", Title="Menu 5"},
            };
        }
    }
}
