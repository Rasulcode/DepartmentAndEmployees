using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmployees
{
    class Employee
    {
        public static int n = 1000;
        public string No;
        public string Fullname { get; set; }
        private string position;
        private int salary;
        public string DepartmentName;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string fullname, string position1, int salary1, string departmentname)
        {
            Fullname = fullname;
            position = position1;
            salary = salary1;
            DepartmentName = departmentname;
            n++;
            if (No == null)
                No = departmentname.Substring(0, 2) + n.ToString();
        }
        public Employee()
        {
            No = "No No";
            Fullname = "No name";
            position = "No position";
            salary = 250;
            DepartmentName = "No DepartmentName";
        }
    }
}
