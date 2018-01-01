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
            SetContentView(Resource.Layout.ActivityTransitionLayout);
            Button button1 = FindViewById<Button>(Resource.Id.GOtoAct2);
            button1.Click += delegate
             {
                 var activity2 = new Intent(this, typeof(Activity2));
                 activity2.PutExtra("MyData", "Data from Activity1");
                 StartActivity(activity2);
             };

        }
    }

}
