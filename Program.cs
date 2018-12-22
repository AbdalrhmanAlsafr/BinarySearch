using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {


        public static void rdiziolustur(int[] dizi, int n)
        {
            Random uretec = new Random();
            for (int i = 0; i < n; i++)
            {
                dizi[i] = uretec.Next(1, 100);
            }
        }

        public static int BinSearch(int[] dizi, int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = dizi.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (dizi[mid] == value)
                    return mid;
                else if (value < dizi[mid])
                    upperBound = mid - 1;
                else
                    lowerBound = mid + 1;

            }
            return -1;
        }

    
          
        static void Main(string[] args)
        {

            int[] A = new int[10];
            rdiziolustur(A, 10);
            Array.Sort(A);
            int sonuc = BinSearch(A, 20);

            Console.WriteLine(sonuc.ToString());
            Console.ReadLine();
            Console.ReadLine();
        }








    }
}
