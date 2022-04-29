Array:
using System;
namespace functionarr
{
 class Program
 {
 void show()
 {
 int[] a = {1,2,3,4,5};
 Console.WriteLine("new function is
invoked!");
 Console.WriteLine(a[3]);
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 Program msg = new Program();
 msg.show();
 }
 }
}
