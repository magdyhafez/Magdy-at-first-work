using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace test
{
    public partial class NavigationPageLearning : ContentPage
    {
        public NavigationPageLearning()
        {
            InitializeComponent();
            Button1.Clicked += Button1_Clicked;    
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
