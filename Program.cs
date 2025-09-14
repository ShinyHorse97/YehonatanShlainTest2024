using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlainTest2024
{
    internal class Program
    {
        public int Calculate(TourPackage[] packages)
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
        public int[] Customers(TourPackage[] packages) 
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
        public int Last(Lesson[] lessons) 
        {
            int last = 0;
            for (int i = 0; i + 1 < lessons.Length; i++) 
            {
                if (lessons[i].IsLater(lessons[i + 1]))
                {
                    last = lessons[i].GetId();
                }
                else
                {
                    last = lessons[i + 1].GetId();
                }
            }
            return last;
        }
        public int sumDuration(Lesson[] lessons, int ID)
        {
            int sum = 0;
            for (int i = 0; i < lessons.Length; i++) 
            {
                if (lessons[i].GetId() == ID)
                {
                    sum += lessons[i].GetDuration();
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
