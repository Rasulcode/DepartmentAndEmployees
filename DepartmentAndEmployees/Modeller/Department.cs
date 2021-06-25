using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmployees
{
    class Department
    {
        private string name;
        private int workerLimit;
        private int salaryLimit;
        public List<Employee> Employees = new List<Employee>();

        public int SalaryLimit
        {
            get { return salaryLimit; }
            set { salaryLimit = value; }
        }

        public int WorkerLimit
        {
            get { return workerLimit; }
            set { workerLimit = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double CalcSalaryAverage()
        {
            int sum = 0;
            foreach (Employee employer in Employees)
            {
                sum += employer.Salary;
            }
            return (double)sum / Employees.Count;
        }
    }
}
