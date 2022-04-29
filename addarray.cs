Addition of array elements:
using System;
namespace functionarr
{
 class Program
 {
 int sum;
 void show()
 {

 int[] a = {4,7,9,6,2};
 for (int i = 0; i < 5; i++)
 {
 sum = sum + a[i];
 }
 Console.WriteLine(sum);
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 Program msg = new Program();
 msg.show();
 }
 }
}
