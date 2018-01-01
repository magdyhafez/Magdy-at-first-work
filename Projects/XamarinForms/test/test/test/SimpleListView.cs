using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace test
{
    public class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            var listView = new ListView
            {
                RowHeight = 40
            };
            listView.ItemsSource = new string[]
            {
    "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
            };
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }
    }
}