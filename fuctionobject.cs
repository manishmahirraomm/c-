Function and object:
using System;
namespace functionarr
{
 class Program
 {
 void show()
 {
 Console.WriteLine("new function is
invoked!");
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 Program msg = new Program();
 msg.show();
 }
 }
}
