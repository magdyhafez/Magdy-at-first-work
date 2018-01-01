using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace test
{
    public partial class Page3_2 : ContentPage
    {
        public Page3_2()
        {
            InitializeComponent();
            Button3.Clicked += Button3_Clicked;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
