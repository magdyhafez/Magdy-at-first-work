using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models;
using Xamarin.Forms;

namespace test
{
    public partial class NewBindingData : ContentPage
    {
        public NewBindingData()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }
    }
}
