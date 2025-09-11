using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlainTest2024
{
    internal class TourPackage
    {
        private int id;
        private int price;
        private int maxTime;
        private int maxData;
        private int extra;

        public TourPackage(int id, int price, int maxTime, int maxData, int extra)
        {
            this.id = id;
            this.price = price;
            this.maxTime = maxTime;
            this.maxData = maxData;
            this.extra = 0;
        }
        public int getId() { return id; }
        public int getPrice() { return price; }
        public int getMaxTime() { return maxTime; }
        public int getMaxData() { return maxData; }
        public int getExtra() { return extra; }
        public void setExtra(int minutes, int usage)
        {
            if (minutes - maxTime > 0) 
            {
                this.extra += minutes - maxTime;
            }
            if (usage - maxData > 0)
            {
                this.extra += (usage - maxData) * 2;
            }
        }
    }
}
