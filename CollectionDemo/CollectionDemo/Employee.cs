using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Employee
    {
        int empno;
        string ename, designation;

        public Employee(int eno, string enm, string desig)
        {
            empno = eno;
            ename = enm;
            designation = desig;
        }

        public override string ToString()
        {
            return "Employee Id= " + empno + ", Name= " + ename + ", Designation= " + designation;
        }
    }
}
