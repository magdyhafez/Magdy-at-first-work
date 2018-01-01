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
        private TextView showCurrentDate;
        protected override void OnCreate(Bundle bundle)
        {
           
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout3);

            DatePicker pickDate = FindViewById<DatePicker>(Resource.Id.datePicker1);
            showCurrentDate = FindViewById<TextView>(Resource.Id.textView1_Date);
            SetCurrentDate();
            Button button = FindViewById<Button>(Resource.Id.button1_click);
            button.Click += delegate {
                showCurrentDate.Text = Java.Lang.String.Format("{0}/{1}/{2}",
                   pickDate.Month, pickDate.DayOfMonth, pickDate.Year);
            };
        }
            
            private void SetCurrentDate()
        {
                string TodaysDate = string.Format("{0}",
         DateTime.Now.ToString("M/d/yyyy").PadLeft(2, '0'));
                showCurrentDate.Text = TodaysDate;
            }

        }

       

        
        
    }


