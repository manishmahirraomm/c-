using System;
namespace interfacedemo
{
 public class student
 {
 public string name;
 public string class1;

 }
 interface exam
 {
 void showsub();
 }
 class result:student,exam
 {
 public void showinfo()
 {
 name = "Manish";
 class1 = "SYBCA";
 Console.WriteLine(name);
 Console.WriteLine(class1);
 }
 public void showsub()
 {
 Console.WriteLine("C#.net");
 Console.ReadLine();
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 result r = new result();
 r.showinfo();
 r.showsub();
 }
 }
}
