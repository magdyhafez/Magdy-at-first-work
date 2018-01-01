using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;

namespace App18
{
    class ClockViewModel2 : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;
      public  ClockViewModel2()
        {
            this.DateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1),() =>
             {
                 this.DateTime = DateTime.Now;
                 return true;
             }
            );
        }
        public DateTime DateTime

        {
            get
            {
                return dateTime;
            }
            set
            {
                if (dateTime != value)
                    dateTime = value;
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this,new  PropertyChangedEventArgs("DateTime"));
                }
            }
        }

    }
}
