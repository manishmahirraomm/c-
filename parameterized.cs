Parameterized Constructor:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace constructor
{
 class paraconstructor
 {
 paraconstructor(int age, String name)
 {
 Console.WriteLine("Name is: "+name);
 Console.WriteLine("Age is: "+age);
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 paraconstructor con = new
paraconstructor(19,"Manish");
 }
 }
}
