using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PassingValueApp
{
    [Activity(Label = "MicroCalculatorApp", MainLauncher = true, Icon = "@drawable/ic_weekend_black_24dp")]
    public class MainActivity : Activity
    {
        float a;
        float b;
        float c;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);                      
            SetContentView (Resource.Layout.LayoutCalcSc1);
            Button add = FindViewById<Button>(Resource.Id.Add_Button);
            EditText first_arg = FindViewById<EditText>(Resource.Id.FirstNumberFiled);
            EditText second_arg = FindViewById<EditText>(Resource.Id.SecondNumberField);
            TextView add_result = FindViewById<TextView>(Resource.Id.AddingResult);
            Button go_to_mult = FindViewById<Button>(Resource.Id.Procced_To_Mult_Btn);
            add.Click += delegate
             {
                 a = float.Parse(first_arg.Text);
                 b = float.Parse(second_arg.Text);
                 c = a + b;
                 add_result.Text = c.ToString();
             };
            go_to_mult.Click += delegate
            {
                var activity2 = new Intent(this, typeof(Activity2));
                activity2.PutExtra("MyData", c.ToString());
                StartActivity(activity2);
            };
            
        }
    }
}

