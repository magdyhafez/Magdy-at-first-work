using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App11
{
    [Activity(Label = "LearningApp-SubActivity")]
    public class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityTransittedTo);
            Button button1 = FindViewById<Button>(Resource.Id.RETURNAct1);
            button1.Click += delegate
             {
                 var activity1 = new Intent(this, typeof(MainActivity));
                 activity1.PutExtra("MyData", "Data from Activity2");
                 StartActivity(activity1);
             };
        }
    }
}