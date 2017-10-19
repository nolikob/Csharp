using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XA01
{
    public abstract class Emlpoyee
    {
        public Emlpoyee(string name, int dailyWage)
        {
            Name = name;
            DailyWage = dailyWage;
        }

        public string Name { get; set; }
        public int DailyWage { get; set; }
    }
}
