using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models;

namespace test.Seader
{
    class StudentSeed
    {
        public List<Student> GetDefaults()
        {
            List<Student> tempList = new List<Student>();
            for (int i = 1; i < 10; i++)
            {
                tempList.Add(new Student {studentName = "Magdy" + i, DoB = new DateTime(1993, 2, i), email = "test@email.com" + i });
            }
                return tempList;
        }
    }
}
