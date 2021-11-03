using System;

namespace School
{
    class Janitor
    {
        // Fields
        private int id;

        // Constructor
        public Janitor (ref int employee, ref int janitor) {
            janitor++;
            //employee++;
            
            this.id = janitor;
        }
    }
}