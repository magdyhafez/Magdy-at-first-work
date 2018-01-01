using Android.App;
using Android.Widget;
using Android.OS;

namespace App10
{
   [Activity(Label = "LearningApp", MainLauncher = true, Icon = "@drawable/ic_accessibility_black_24dp")]
    public class MainActivity : Activity    
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = "Hello I am you first app"; };
            CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1);
            checkMe.CheckedChange += CheckMe_CheckedChange;
        }

        private void CheckMe_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
                check.Text = "I am Checked";
            else
                check.Text = "I am unchecked";
        }
    }
}

