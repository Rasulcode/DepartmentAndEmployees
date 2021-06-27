using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentAndEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager hrm = new HumanResourceManager();
            Employee isci1 = new Employee("Natiq Esedov", "Qeydiyyatci", 350, "IHQD");
            Employee isci2 = new Employee("Fuad Huseynli", "Qeydiyyatci", 275, "HHQD");
            Employee isci3 = new Employee("Aysun Agayeva", "Telimci", 375, "QHQD");
            Employee isci4 = new Employee("Fidan Babayeva", "Katibeci", 400, "HHQD");
            Employee isci5 = new Employee("Zaur Ehmedli", "Qeydiyyatci", 300, "IHQD");

            Department InsanHuquqlarininQorunmasi = new Department
            {
                Name = "IHQD",
                WorkerLimit = 5,
                SalaryLimit = 2300
            };
            Department QadinHuquqlarininQorunmasi = new Department
            {
                Name = "QHQD",
                WorkerLimit = 3,
                SalaryLimit = 3370
            };
            Department HeyvanHuquqlarininQorunmasi = new Department
            {
                Name = "HHQD",
                WorkerLimit = 7,
                SalaryLimit = 1100
            };

            HeyvanHuquqlarininQorunmasi.Employees.Add(isci2);
            HeyvanHuquqlarininQorunmasi.Employees.Add(isci4);
            InsanHuquqlarininQorunmasi.Employees.Add(isci1);
            InsanHuquqlarininQorunmasi.Employees.Add(isci5);
            QadinHuquqlarininQorunmasi.Employees.Add(isci3);

            hrm.Departments.Add(InsanHuquqlarininQorunmasi);
            hrm.Departments.Add(HeyvanHuquqlarininQorunmasi);
            hrm.Departments.Add(QadinHuquqlarininQorunmasi);

            Console.WriteLine("\t\tMovcud Isciler");
            foreach (var department in hrm.Departments)
            {
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine("Isci Nomresi : " + employee.No
                        + "\tIsci Ad ve Soyadi : " + employee.Fullname
                        + "\tIscinin Departamentinin adi : " + employee.DepartmentName
                        + "\tIscinin Geliri : " + employee.Salary
                        + "\tIscinin Vezifesi : " + employee.Position);
                }
            }
        
        }
    }
}
