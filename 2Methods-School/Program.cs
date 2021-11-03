using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Students: ");
            //Console.WriteLine(School.getStudents());
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            Student student_5 = new Student(ref School.students);
            Console.WriteLine(School.getStudents());
            
            Console.WriteLine("Employees: ");
            Employee employee_1 = new Employee(ref School.employees, ref School.teachers, ref School.janitors);
            Employee employee_2 = new Employee(ref School.employees, ref School.teachers, ref School.janitors);
            Employee employee_3 = new Employee(ref School.employees, ref School.teachers, ref School.janitors);
            Employee employee_4 = new Employee(ref School.employees, ref School.teachers, ref School.janitors);
            Employee employee_5 = new Employee(ref School.employees, ref School.teachers, ref School.janitors);
            Console.WriteLine(School.getEmployees());

            Console.WriteLine("Teachers: ");
            //Console.WriteLine(School.getTeachers());
            Teacher teacher_1 = new Teacher(ref School.teachers,ref School.employees);
            Teacher teacher_2 = new Teacher(ref School.teachers,ref School.employees);
            Teacher teacher_3 = new Teacher(ref School.teachers,ref School.employees);
            Teacher teacher_4 = new Teacher(ref School.teachers,ref School.employees);
            Teacher teacher_5 = new Teacher(ref School.teachers,ref School.employees);
            Console.WriteLine(School.getTeachers());
            
            Console.WriteLine("Janitors: ");
            //Console.WriteLine(School.getJanitors());
            Janitor janitor_1 = new Janitor(ref School.janitors,ref School.employees);
            Janitor janitor_2 = new Janitor(ref School.janitors,ref School.employees);
            Janitor janitor_3 = new Janitor(ref School.janitors,ref School.employees);
            Janitor janitor_4 = new Janitor(ref School.janitors,ref School.employees);
            Janitor janitor_5 = new Janitor(ref School.janitors,ref School.employees);
            Console.WriteLine(School.getJanitors());
        }
    }
}
