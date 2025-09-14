using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlainTest2024
{
    internal class Lesson
    {
        private int id;
        private int hh;
        private int mm;
        private int duration;
        public Lesson(int id, int hh, int mm, int duration)
        {
            this.id = id;
            if (hh < 8 || hh > 17 || mm < 0 || mm > 59)
            {
                this.hh = hh;
                this.mm = mm;
            }
            this.duration = duration;
        }
        public int GetId() { return id; }
        public int GetHh() { return hh; }
        public int GetMm() { return mm; }
        public int GetDuration() { return duration; }
        public void SetTime(int hh, int mm)
        {
            if (hh < 8 || hh > 17 || mm < 0 || mm > 59)
            {
                this.hh = hh;
                this.mm = mm;
            }
            else
            {
                Console.WriteLine("invalid time");
                
            }
        }
        public void SetDuration(int duration)
        {
            this.duration = duration;
        }
        public bool IsLater(Lesson other) 
        {
            if (this.hh > other.hh)
            {
                return true;
            }
            else if (this.hh == other.hh && this.mm > other.mm)
            {
                return true;
            }
            return false;
        }
    }
}
