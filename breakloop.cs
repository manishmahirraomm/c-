Break in while loop:
using System;
namespace whileloop
{
 class Program
 {
 static void Main(string[] args)
 {
 int i = 1, a;
 Console.WriteLine("Enter the last integer upto the even numbers
you want: ");
 a = int.Parse(Console.ReadLine());
 while (i <= a)
 {
 if (i % 2 == 0)
 {
 if (i > 6)
{
 break;
 }
 Console.WriteLine(i);
 }
 i++;
 }
 Console.ReadLine();
 }
 }
}
