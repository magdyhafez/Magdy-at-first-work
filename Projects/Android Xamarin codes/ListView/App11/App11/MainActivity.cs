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
            SetContentView(Resource.Layout.Main);
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var data=new string[]{"Sunday" , "Monday" , "Tuesday" , "Wednesday","Thursday","Friday","Saturday"};
            listView.Adapter = new ArrayAdapter(this, Resource.Layout.listViewTemplate,data);
        }
       
    }
}


