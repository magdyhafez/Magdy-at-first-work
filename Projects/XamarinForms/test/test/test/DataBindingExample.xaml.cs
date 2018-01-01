using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models;
using Xamarin.Forms;
using test.Seader;

namespace test
{
    public partial class DataBindingExample : ContentPage
    {
        public DataBindingExample()
        {
            StudentSeed students = new StudentSeed();
            // Student student = new Student();
            //student.studentName = "Magdy";
            //student.DoB = new DateTime(1993, 2, 9);
            BindingContext = students.GetDefaults();
            InitializeComponent();
        }
    }
}
