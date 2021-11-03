using System;

namespace School
{
    class Teacher
    {
        // Fields
        private int id;

        // Constructor
        public Teacher (ref int employee, ref int teacher) {
            teacher++;
            //employee++;
            this.id = teacher;
        }
    }
}