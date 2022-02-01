using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Student
    {
            int rollNo;
            string name, course;

            public Student(int rollNo, string name, string course)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.course = course;
            }

            public override string ToString()
            {
                return "Student Roll Number= " + rollNo + ", Name= " + name + ", Course= " + course;
            }
        }
}
