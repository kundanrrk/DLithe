using System;
namespace EmployeeDetails
{
    class Employee
    {
        int id;
        string name;
        string department;
        double salary;
        public void InsertData(int i, string s, string dept, double sal)
        {
            id = i;
            name = s;
            department = dept;
            salary = sal;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + department + "  " + salary);
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();

            emp1.InsertData(101, "Mahesh", "IT", 27500.50);
            emp2.InsertData(102, "Suresh", "HR", 28500.70);
            emp3.InsertData(103, "Raj", "DBA", 29500.60);
            emp4.InsertData(104, "Naresh", "Tester", 26500.65);
            emp5.InsertData(105, "Lokesh", "Java_Devloper", 30500.50);

            Console.WriteLine("\n");
            Console.WriteLine("Employee Details:- ");
            Console.WriteLine("-------------------------- ");
            Console.WriteLine("\n");

            emp1.display();
            emp2.display();
            emp3.display();
            emp4.display();
            emp5.display();

            Console.WriteLine("\n");
            Console.WriteLine("-------------------------- ");
            Console.WriteLine("\n");

            int result;
            int x = 20, y = 10;
            Console.WriteLine("Arithmetic Operators two variable that are as follow; -" + x + ", " + y);
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------- ");
            Console.WriteLine("\n");
            Console.WriteLine("Swapping String Using Third Variable");
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a= " + a + " b= " + b);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------- ");
            Console.WriteLine("\n");

            int no1 = 7, no2 = 11, no3 = 5;
            Console.WriteLine("Largest of Three No:- " + no1 + " " + no2 + " " + no3);
            if (no1 > no2)
            {
                if (no1 > no3)
                {
                    Console.WriteLine("no1 is largest:- " + no1);
                }
                else
                {
                    Console.WriteLine("no3 is largest among them:- " + no2);
                }
            }
            else if (no2 > no3)
                Console.Write("no2 is the largest:- " + no2);
            else
                Console.Write("no3 is the largest:- " + no3);
        }
    }
}
