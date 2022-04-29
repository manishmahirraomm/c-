Parameterized Constructor at Runtime:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace constructor
{
 class paraconstructor
 {
 int a;
 String n;
 paraconstructor(int age, String name)
 {
 a = age;
 n = name;
 }
 static void Main(string[] args)
 {
 paraconstructor con = new
paraconstructor(19,"Manish");
 Console.WriteLine("Age is: "+
con.a);
 Console.WriteLine("Name is:
"+con.n);
 Console.ReadLine();
 }
 }
}
