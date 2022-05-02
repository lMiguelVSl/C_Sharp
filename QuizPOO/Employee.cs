using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPOO
{
    public class Employee : Person
    {
        private int EmployeeId { get; set; }
        private string FullName { get;}
        public int Age { get; set; }

        public int employeeId
        {
            get { return EmployeeId; }
            set { EmployeeId = value; }
        }
        public Employee (int _EmployeeId, string fullName, int age) : base(fullName,age)
        {
            employeeId = _EmployeeId;
            FullName = fullName;
            Age = age;
        }
          

        public override string GetData()
        {
            return  $"Full Name: {FullName} \n" +
                $"Age: {Age} \n" +
                $"Employee id: {employeeId} ";
        }

    }
    
}
