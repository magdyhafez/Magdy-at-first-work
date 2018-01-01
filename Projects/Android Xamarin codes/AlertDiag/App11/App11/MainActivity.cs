using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Resource;
using System;

namespace App11
{
    [Activity(Label = "SelfLearningApp", MainLauncher = true, Icon = "@drawable/ic_accessibility_black_24dp")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate {
                AlertDialog.Builder alterdialog = new AlertDialog.Builder(this);
                alterdialog.SetTitle("Confirm Delete");
                alterdialog.SetMessage("Once deleted cannot be redone");
                alterdialog.SetPositiveButton("Delete", (senderAlert, args) => { Toast.MakeText(this, "Deleted", ToastLength.Short).Show(); });
                alterdialog.SetNegativeButton("Cancel", (senderAlert, args) => { alterdialog.Dispose(); });
                Dialog diag = alterdialog.Create();
                diag.Show();
            
              
            };
            
        }
        
    }
}


