using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TabbledPageApp
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            this.Title = "TABS";

            Children.Add(new Page
            {
                Title = "TAB 1",
            });

            Children.Add(new Page1());

            Children.Add(new Page2());


            this.SelectedItem = Children[2];

        }
    }
}
