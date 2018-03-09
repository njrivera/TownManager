using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class Building
    {
        private int monthsRemaining;
        private string type;
        private string job;
        private int capacity;

        public Building(string t, int m, string j = "", int c = 0)
        {
            type = t;
            monthsRemaining = m;
            job = j;
            capacity = c;
        }

        public string getType()
        {
            return type;
        }

        public int getMonths()
        {
            return monthsRemaining;
        }

        public string getJob()
        {
            return job;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public void Build(int workers)
        {
            monthsRemaining -= workers;
            if (monthsRemaining < 0)
                monthsRemaining = 0;
        }
    }
}
