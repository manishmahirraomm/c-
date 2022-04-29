using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace methodoverloading
{
 class methodover
 {
 public void add(int a,int b)
 {
 Console.WriteLine(a+b);
 }
 public void add(int a,int b,int c)
 {
 Console.WriteLine(a+b+c);
 Console.ReadLine();
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 methodover mo = new methodover();
 mo.add(5,6);
 mo.add(7, 3, 9);
 }
 }
}
