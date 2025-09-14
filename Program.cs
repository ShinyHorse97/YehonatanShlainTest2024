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
        // Ex 3
        public static void Shuffle(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                int index1 = rand.Next(0, arr.Length);
                int index2 = rand.Next(0, arr.Length);
                if (index1 != index2)
                {
                    int temp = arr[index1];
                    arr[index1] = arr[index2];
                    arr[index2] = temp;
                }
                else { i--; }
            }
            Console.WriteLine("shuffle: " + string.Join(", ", arr));
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
        public static void Last(Lesson[] lessons)
        {
            Lesson last = lessons[0];
            for (int i = 0; i < lessons.Length - 1; i++)
            {
                if (lessons[i].IsLater(last))
                    last = lessons[i];
            }
            Console.WriteLine("Last: " + last.GetId());
        }
        public static int SumDuration(Lesson[] lessons, int ID)
        {
            int sum = 0;
            for (int i = 0; i < lessons.Length; i++)
            {
                if (lessons[i].GetId() == ID)
                    sum += lessons[i].GetDuration();
            }
            return sum;
        }
        public static int Longest(Lesson[] lessons)
        {
            int max = lessons[0].GetId();
            for (int i = 1; i < lessons.Length; i++)
            {
                if (SumDuration(lessons, lessons[i].GetId()) > SumDuration(lessons, max))
                    max = lessons[i].GetId();
            }
            return max;
        }

        // Ex 6
        public static int digitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public static int DeepSum(int num)
        {
            while (num >= 10)
            {
                num = digitSum(num);
            }
            return num;
        }

        public static bool IsCorrect()
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 1; i <= 999999; i++)
            {
                int deep = DeepSum(i);
                if (deep % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            return evenCount > oddCount;
        }
        public static bool digitExists(int num, int digit)
        {
            while (num > 0)
            {
                if (num % 10 == digit)
                    return true;
                num /= 10;
            }
            return false;
        }
        public static bool InBoth(int num1, int num2)
        {
            int deep1 = DeepSum(num1);
            int deep2 = DeepSum(num2);
            return digitExists(num2, deep1) && digitExists(num1, deep2);
        }

        //Main
        static void Main(string[] args)
        {
            // Ex 2
            Console.WriteLine("Ex 2");
            Console.WriteLine("");
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("change: " + GetPass(arr, 10) + "-" + " " + string.Join(",", arr));
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("no change: " + GetPass(arr1, 3) + "-" + " " + string.Join(",", arr1));
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            // Ex 3
            Console.WriteLine("Ex 3");
            Console.WriteLine("");
            int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original Arr: " + string.Join(",", arr2));
            Shuffle(arr2);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            // Ex 4
            Console.WriteLine("Ex 4");
            Console.WriteLine("");
            TourPackage[] packages = new TourPackage[3];
            packages[0] = new TourPackage(1, 100, 60, 500, 0);
            packages[1] = new TourPackage(2, 200, 120, 1000, 0);
            packages[2] = new TourPackage(3, 300, 180, 1500, 0);
            packages[0].setExtra(70, 600);
            packages[1].setExtra(130, 1100);
            packages[2].setExtra(180, 1500);
            Console.WriteLine("Packages: " + string.Join(", ", packages[0].ToString(), "| ", packages[1].ToString(), "| ", packages[2].ToString(), "| "));
            Console.WriteLine("Calculate:" + Calculate(packages));
            int[] arr3 = Customers(packages);
            Console.WriteLine("packages: " + string.Join(", ", arr3));
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            // Ex 5
            Console.WriteLine("Ex 5");
            Console.WriteLine("");
            Lesson[] lessons = new Lesson[5];
            lessons[0] = new Lesson(1, 9, 0, 60);
            Console.WriteLine("lesson 1: " + lessons[0].ToString());
            lessons[1] = new Lesson(2, 10, 0, 90);
            Console.WriteLine("lesson 2: " + lessons[1].ToString());
            lessons[2] = new Lesson(1, 11, 30, 60);
            Console.WriteLine("lesson 3: " + lessons[2].ToString());
            lessons[3] = new Lesson(3, 13, 0, 120);
            Console.WriteLine("lesson 4: " + lessons[3].ToString());
            lessons[4] = new Lesson(2, 15, 0, 60);
            Console.WriteLine("lesson 5: " + lessons[4].ToString());
            Last(lessons);
            Console.WriteLine("Id:1, Sumduration: " + SumDuration(lessons, 1));
            Console.WriteLine("Longest: " + Longest(lessons));
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            // Ex 6
            Console.WriteLine("Ex 6");
            Console.WriteLine("");
            Console.WriteLine("DeepSum of 9875: " + DeepSum(9875));
            Console.WriteLine("IsCorrect: " + IsCorrect());
            Console.WriteLine("InBoth of 123 and 456: " + InBoth(123, 456));
            Console.WriteLine("InBoth of 942378 and 36: " + InBoth(942378, 36));
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}
