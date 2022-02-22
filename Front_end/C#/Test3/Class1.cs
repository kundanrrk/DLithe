using Nest;
using System;
namespace DLithe
{
    public class A
    {
        public string Name;
        public void GetName()
        {
        
            Console.WriteLine("Name: {0}", Name);
 }
}


        public class B : A
        {
            public string Location;
            public void GetLocation()
            {
                Console.WriteLine("Location: {0} ", Location);
            }
        }
        public class C : B
        {
            public int Age;

          

            public void GetAge()
            {
                Console.WriteLine("Age: {0}", Age);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                C c = new C();
                c.Name = "Kundan Kumar";
                c.Location = "Banglore";
                c.Age = 25;
             c.GetAge();
             c.GetName();
             c.GetLocation();
              Console.WriteLine("\nPress Any Key to Exit..");
              Console.ReadLine();
            }
        }
    }