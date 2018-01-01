using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.ViewModels;
using Xamarin.Forms;

namespace test
{
    public partial class DataBindingMVVM : ContentPage
    {
        public DataBindingMVVM()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}
