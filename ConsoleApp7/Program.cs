using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task no1;
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (number>0)
            //{
            //    number= number / 10;
            //    count++;
            //}
            //Console.WriteLine(count);
            //int r, i = 0;
            //if (count % 2 == 0)
            //    i = 0;
            //else
            //    i= 1;

            //while (number!=0)
            //{
            //    r = number % 10;
            //    number = number / 10;

            //    if(i%2==0)
            //    {
            //        Console.WriteLine(r);
            //    }
            //    i++;
            //}


            //task no2;
            //int number = int.Parse(Console.ReadLine());


            //int count = (int)Math.Log10(number) + 1;
            //int r,sum=0;
            //while(number!=0)
            //{
            //    r = number % 10;
            //    number = number / 10;
            //    sum = sum + r * count;
            //    count--;
            //}
            //Console.WriteLine(sum);

            //task no5;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                if(Math.Sqrt(i)==(int)Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
