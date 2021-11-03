using System;

namespace School
{
    class Employee
    {
        // Fields
        private int id;

        // Constructor
        public Employee (ref int employee, ref int teacher, ref int janitor)
         {
             teacher++;
             janitor++;
             employee++;

             
            this.id = employee;
        }
    }
}