Default Constructor:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace constructor
{
 class defconstructor
 {
 defconstructor()
 {
 Console.WriteLine("Constructor
called");
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 defconstructor con = new
defconstructor();
 }
 }
}
