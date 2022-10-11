using System;
using System.Collections.Generic;
using System.Text;

namespace Better_Stats
{
    public struct RangedStat
    {
        int min, max;

        public static int Diff=3;

        public RangedStat(int Max)
        {
            max = Max;
            min = 0;
        }
        public RangedStat(int Max, int Min)
        {
            max = Max;
            min = Min;
        }
        void Add(int length=1)
        {
            int v = 0;
            for (int i = 0; i < length; i++)
            {
                max++;
                v++;
                if (v >= Diff)
                {
                    v = 0;
                    min++;
                }
            }
        }

        public static implicit operator int(RangedStat stat)
        {
            Random random = new Random();
            return random.Next(stat.min, stat.max);
        }
        public static implicit operator RangedStat(int x)
        {
            return new RangedStat(x);
        }

        public static RangedStat operator++(RangedStat stat)
        {
            stat.Add();
            return stat;
        }
        public static RangedStat operator+(RangedStat a,int b)
        {
            a.Add(b);
            return a;
        }
    }
}
