using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace table
{
 class table
 {
 int num;
 table(int a)
 {
 Console.WriteLine("table of "+a+"
is: \n");
 for (int i = 1; i <= 10; i++)
 {
 Console.WriteLine(a*i);
 }
 Console.ReadLine();
 }
 ~table()
 {
 Console.WriteLine("Destructor
called.");
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 int num;
 Console.WriteLine("Enter a number to
print it's table: ");
 num = int.Parse(Console.ReadLine());
 table t1 = new table(num);
 }
 }
}
