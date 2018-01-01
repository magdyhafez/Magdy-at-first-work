using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Resource;
using System;
using Android.Content;
using Android.Views;
using Java.Lang;


namespace App11
{
    [Activity(Label = "SelfLearningApp", MainLauncher = true, Icon = "@drawable/ic_accessibility_black_24dp")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout5);
            var listview = FindViewById<ListView>(Resource.Id.My_List_V);
            var data = new string[] {"Egypt","Algeria","Italy" };
            listview.Adapter = new ArrayAdapter(this, Resource.Layout.listViewTemplate,data);

        }
    }

}
