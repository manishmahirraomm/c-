using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace meoverriding
{
 class A
 {
 public void add(int a, int b)
 {
 Console.WriteLine("Addition: "+ a +
b);
 }
 }
 class B:A
 {
 public void add(int a, int b)
 {
 Console.WriteLine("Addition: " + a +
b);
 Console.ReadLine();
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 B b = new B();
 b.add(5,5);
 b.add(6,6);
 }
 }
}
