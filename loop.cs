using System;
namespace looping
{
 class Program
 {
 static void Main(string[] args)

 {
 int i = 1, a;
 Console.WriteLine("Enter the last integer
upto the even numbers you want: ");
 a=int.Parse(Console.ReadLine());
 for (i = 1; i <= a; i++)
 {
 if (i % 2 == 0)
 {
 Console.WriteLine(i);
 }
 }
 Console.ReadLine();
 }
 }
}
