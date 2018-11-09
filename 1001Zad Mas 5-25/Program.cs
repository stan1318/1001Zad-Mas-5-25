using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001Zad_Mas_5_25
{
    class Program{
   
        static void Main(string[] args)
        {
            Console.WriteLine("How long do you want your array?(from 5-25):");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n<5||n>25){
                Console.WriteLine("Invalid array lenght,please make it between 5 and 25:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] mas=new int[n];
            string[] sarr = new string[n];
            Console.WriteLine("Type in the array members with a space between them:");
            sarr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(sarr[i]);
            }
            List<int> lst = mas.OfType<int>().ToList();
           
            OddOut(lst);
           // EvenSquared(lst);
           // OverAverage(lst);
           
          
            Console.ReadLine();

        }
        static void OddOut(List<int>lst )
        {//removes the odd numbers in the array
           
            for (int i = 0; i < lst.Count ; i++)
            {
                if (lst[i] % 2 == 1)
                {
                    lst.RemoveAt(i);
                }
               
            }
            foreach (int even in lst)
            {
                Console.WriteLine(even);
            }



        }
        static void EvenSquared(List<int>lst)
        {//Prints out the array and every even number is squared
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 == 0)
                {
                    lst.Insert(i + 1, (lst[i] * lst[i]));
                    i++;
                }
                
            }
            foreach(int num in lst)
            {
                Console.WriteLine(num);
            }


        }
        static void OverAverage(List<int>lst)
        {//prints the Average of the array and the numbers higher than it
            float sum=0;
            int n=lst.Count;
            for (int i = 0; i < n; i++)
            {
                sum = sum + lst[i];
            }

            float avg = sum / n;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] < avg)
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("Average is:{0}",avg);
             foreach (int num in lst)
             {
               Console.WriteLine(num);
             }
        }
    }
}
