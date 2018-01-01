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

namespace PassingValueApp
{
    [Activity(Label = "Mutiply Screen", Icon = "@drawable/ic_weekend_black_24dp")]
    public class Activity2 : Activity
    {
        private float first_arg;
        private string first_arg_from_Previous_act;
        private float second_arg;
        private float result;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CalcSc2);
            first_arg_from_Previous_act = Intent.GetStringExtra("MyData") ?? "Data not available";
            Button multiply = FindViewById<Button>(Resource.Id.Mult_Button);
            EditText second_arg_string_Edit_text = FindViewById<EditText>(Resource.Id.MultiplyingArg);
            TextView quotient = FindViewById<TextView>(Resource.Id.MutiplyResult);
            TextView previous_result = FindViewById<TextView>(Resource.Id.ResultFromPreviousActivity);
;            if (first_arg_from_Previous_act!= "Data not available")
            {
                previous_result.Text = first_arg_from_Previous_act;
                first_arg = float.Parse(first_arg_from_Previous_act);

            }


            multiply.Click += delegate
            {
                second_arg=float.Parse(second_arg_string_Edit_text.Text);
                result = first_arg * second_arg;
                quotient.Text = result.ToString();

            };        

        }
    }
}