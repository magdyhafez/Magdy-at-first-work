using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace test
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Button2.Clicked += Button2_Clicked;
            Button4.Clicked += Button4_Clicked;
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3_2());
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
