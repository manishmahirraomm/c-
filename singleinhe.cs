using System;
namespace inheritance
{
 public class stud
 {
 public string name="Manish";
 public string class1="SYBCA";
 void showinfo()
 {
 Console.WriteLine("Name= " + name +
" Class= " + class1);

 }
 }
 public class exam: stud
 {
 public void showsub()
 {
 string sub="C#.Net";
 Console.WriteLine("" Subject= "+sub);
 Console.ReadLine();
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 exam ex=new exam();
 ex.showinfo();
 ex.showsub();
 }
 }
}
