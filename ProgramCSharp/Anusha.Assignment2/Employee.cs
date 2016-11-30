using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anusha.Assignment2
{
    class Employee
    {
        // Hold Name, Address, DateOfBirth, CompanyName, Salary and DateOfJoin for each Employee.
        public string employeeName { get; set; }
        public string employeeAddress { get; set; }
        public DateTime dateOfBiirth { get; set; }
        public static string companyName { get; set; }
        public float salary { get; set; }
        public DateTime dateOfJoining { get; set; }
        

        public Employee()
        {
            companyName = "Microsoft";
        }
        // Implement a method to return annual bonus of an employee (10% of Salary)
        public float AnnualBonus (Employee employee)
        {
            
            float annualBonus = (employee.salary * 10) / 100;
            return annualBonus;
        }
        // Implement a method to return HeadQuarters of Company
        public static string HeadQuarters()
        {
            string headQuarters = " Redmond";
            return headQuarters;
        }
        //Implement a method to return Band of an employee. If an employee is working for 
  //+	  i. 0-1 years, then Band A
  //+	 ii. 1-5 years, then Band B
  //+	iii. 5-10 years, then Band C
  //+	 iv. 10-15 years, then Band D
  //+	  v.More than 15 years, then Band E
        public char BandOfEmployee(Employee employee)
        {
            int experience = Convert.ToInt32 (DateTime.Now.Subtract(employee.dateOfJoining).TotalDays);
            experience = experience / 365;
            if(experience )
        }



    }
}
