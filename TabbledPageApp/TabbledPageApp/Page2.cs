using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TabbledPageApp
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            Title = "tab 3";

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage trtrtrtr" }
                }
            };
        }
    }
}
