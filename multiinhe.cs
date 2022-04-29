using System;
namespace inheritance
{
 public class stud
 {
 public string name="Manish";
 public string class1="SYBCA";
 public void showinfo()
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
 Console.WriteLine("Subject= "+sub);
 }
 }
 public class mark : exam
 {
 public void showmarks()
 {
 int marks = 50;
 Console.WriteLine("Marks= " +
marks);
 Console.ReadLine();
 }
 }
 class Program
 {
 static void Main(string[] args)
 {
 mark mk=new mark();
 mk.showinfo();
 mk.showsub();
 mk.showmarks();
 }
 }
}
