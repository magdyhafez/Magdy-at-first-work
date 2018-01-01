using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App18
{
    class KeypadViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string inputString = "";
        string displayText = "";
        char[] specialChars = { '*', '#' };

        public string InputString
        {
            get { return inputString; }
           protected  set                                             //Missing protected
            {
                if (inputString != value)
                    inputString = value;
                OnPropertyChanged("InputString");
                DisplayText = FormatText(inputString);
                ((Command)DeleteCharCommand).ChangeCanExecute();
            }
        }
        public ICommand AddCharCommand { protected set; get; }

        public ICommand DeleteCharCommand { protected set; get; }
        public string DisplayText
        {
            get { return displayText; }
            protected set
            {
                if (displayText != value)
                    displayText = value;
                OnPropertyChanged("DisplayText");
            }
        }
        string FormatText(string str)
        {
            bool hasNonNumbers = str.IndexOfAny(specialChars) != -1;
            string formatted = str;

            if (hasNonNumbers || str.Length < 4 || str.Length > 10)
            {
            }
            else if (str.Length < 8)
            {
                formatted = String.Format("{0}-{1}",
                                          str.Substring(0, 3),
                                          str.Substring(3));
            }
            else
            {
                formatted = String.Format("({0}) {1}-{2}",
                                          str.Substring(0, 3),
                                          str.Substring(3, 3),
                                          str.Substring(6));
            }
            return formatted;
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public KeypadViewModel()
        {
            AddCharCommand = new Command<string>((key) => { InputString += key; });
            DeleteCharCommand = new Command(() => { InputString = InputString.Substring(0, InputString.Length - 1); });
        }
    }
}
     

