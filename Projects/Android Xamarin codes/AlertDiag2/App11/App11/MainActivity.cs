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
            SetContentView(Resource.Layout.layout4);
            Button delete_button = FindViewById<Button>(Resource.Id.ClickToDeleteButton);
            delete_button.Click += delegate {
                AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
                alertDiag.SetTitle("Confirm delete");
                alertDiag.SetMessage("Once deleted the move cannot be undone");
                alertDiag.SetPositiveButton("Delete", (senderAlert, args) => {
                    Toast.MakeText(this, "Deleted", ToastLength.Short).Show();
                });
                alertDiag.SetNegativeButton("Cancel", (senderAlert, args) => {
                    alertDiag.Dispose();
                });
                Dialog diag = alertDiag.Create();
                diag.Show();
            

        };


        }
    }

}
