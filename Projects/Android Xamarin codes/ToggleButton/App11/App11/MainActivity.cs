using Android.App;
using Android.Widget;
using Android.OS;

namespace App11
{
    [Activity(Label = "SelfLearningApp", MainLauncher = true, Icon = "@drawable/ic_accessibility_black_24dp")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);
            ToggleButton tooglebutton = FindViewById<ToggleButton>(Resource.Id.togglebutton);
            tooglebutton.Click += Tooglebutton_Click;
        }

        private void Tooglebutton_Click(object sender, System.EventArgs e)
        {
            ToggleButton tg = (ToggleButton)(sender);
            if (tg.Checked)
            {
                Toast.MakeText(this, "Tourch is ON", ToastLength.Short).Show();
            }
            else
                Toast.MakeText(this, "Tourch is OFF", ToastLength.Short).Show();
        }
    }
}

