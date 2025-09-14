using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlainTest2024
{
    internal class Program
    {
        // Ex 2
        public static bool GetPass(int[] arr, int password)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == password)
                {
                    return false; 
                }
            }
            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = password;
            return true;
        }
        // Ex 4
        public static int Calculate(TourPackage[] packages)
        {
            int count = 0;
            for (int i = 0; i < packages.Length; i++)
            {
                if (packages[i].getExtra() != 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] Customers(TourPackage[] packages) 
        {
            int[] Id = new int[Calculate(packages)];
            int index = 0;
            for (int i = 0; i < packages.Length; i++)
            {
                if (packages[i].getExtra() != 0)
                {
                    Id[index] = packages[i].getId();
                    index++;
                }
            }
            return Id;
        }
        // Ex 5
        public int SumDuration(Lesson[] lessons, int ID)
        {
            int sum = 0;
            for (int i = 0; i < lessons.Length; i++)
            {
                if (lessons[i].GetId() == ID)
                    sum += lessons[i].GetDuration();
            }
            return sum;
        }
        public int Longest(Lesson[] lessons)
        {
            int max = lessons[0].GetDuration();
            for (int i = 1; i < lessons.Length; i++)
            {
                if (lessons[i].GetDuration() > max)
                    max = lessons[i].GetDuration();
            }
            return max;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TourPackage[] packages = new TourPackage[3];
            packages[0] = new TourPackage(1, 100, 60, 500, 0);
            packages[1] = new TourPackage(2, 200, 120, 1000, 0);
            packages[2] = new TourPackage(3, 300, 180, 1500, 0);
            packages[0].setExtra(70, 600);
            packages[1].setExtra(130, 1100);
            packages[2].setExtra(180, 1500);
            Console.WriteLine(Calculate(packages));
            int[] arr1 = Customers(packages);
            Console.WriteLine(string.Join("","", arr1));
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(GetPass(arr, 10));
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
