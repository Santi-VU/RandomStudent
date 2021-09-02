using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStudent
{
    class Student
    {
        public String Name { get; set; }
        public StudentType StudentType { get; set; }

        public Student(String name, StudentType st)
        {
            Name = name;
            StudentType = st;
        }
    }
}
