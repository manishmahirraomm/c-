Max value from array:
using System;
namespace functionarr
{
 class Program
 {
 int sum,maximum,i,j;
 int[] a = {4,7,9,6,2};
 void show()
 {
 for (i = 0; i < 5; i++)
 {
 sum = sum + a[i];
 }
 Console.WriteLine("sum= "+sum);
 }
 void maxi()
 {
 for (j = 0; j < 5; j++)
 {
 //maximum=a[j];
 if (a[j] > maximum)
 {
 maximum = a[j];
 }
 else
 {
 Console.WriteLine("max= " +
maximum);
 }
 }

 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 Program msg = new Program();
 msg.show();
 msg.maxi();
 }
 }
}
