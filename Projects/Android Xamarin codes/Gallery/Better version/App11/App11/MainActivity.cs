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
            Gallery myGallerry = FindViewById<Gallery>(Resource.Id.gallery1);
            myGallerry.Adapter = new ImageAdapter(this);
            myGallerry.ItemClick += delegate (object sender,AdapterView.ItemClickEventArgs args ) {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
                };
            

        }
    }

}
