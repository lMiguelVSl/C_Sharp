using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPOO
{
    public abstract class Person
    {
        private string FullName { get; set; }
        public int Age { get; set; }

        public string Name
        {
            get { return FullName; }
            set { FullName = Name; }
        }

        public Person (string fullName, int age)
        {
            this.Name = fullName;
            this.Age = age;
        }
        public virtual string GetData()
        {
            return $"Full Name: {FullName} \n" +
                $"Age: {Age}";
        }
    }
 
}
