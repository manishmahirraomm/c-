Constructor accessing private member:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace constructor
{
 class defconstructor
 {
 int age;
 defconstructor()
 {
 age = 29;
 Console.WriteLine(age);
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 defconstructor con = new
defconstructor();
 }
 }
}
