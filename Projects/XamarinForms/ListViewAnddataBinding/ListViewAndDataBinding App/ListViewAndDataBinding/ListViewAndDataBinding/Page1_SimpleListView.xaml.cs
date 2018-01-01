using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewAndDataBinding
{
    public partial class Page1_SimpleListView : ContentPage
    {
        public Page1_SimpleListView()
        {
            InitializeComponent();
            MainListView.ItemsSource = new List<Person>
            {
                new Person() {Name="Magdy",Age=24 },
                new Person() {Name="Ibrahim",Age=25 },
                new Person() {Name="Omar",Age=22 }
                
            };
        }
    }
}
