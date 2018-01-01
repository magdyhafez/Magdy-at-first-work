using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models;

namespace test.ViewModels
{
    class HomeViewModel
    {
        public TaskModel TaskModel { set; get; }
        public HomeViewModel()
        {
            TaskModel = new TaskModel
            {
                tittle = "Creating UI",
                duration = 2
            };
        }
    }
}
