namespace Better_Stats
{
    public struct TrainedStat
    {
        int Level;
        int exp;
        public static int Threshhold = 32;
        public TrainedStat(int lvl)
        {
            Level = lvl;
            exp = 0;
        }

        public static implicit operator int(TrainedStat stat) => stat.Level;
        public static implicit operator TrainedStat(int lvl) => new TrainedStat(lvl);
        void Add(int x =1)
        {
            for (int i = 0; i < x; i++)
            {
                exp++;
                if(exp >= Threshhold*Level)
                {
                    exp = 0;
                    Level++;
                }
            }
        }
        void Subtract(int length = 1)
        {
            for (int i = 0; i < length; i++)
            {
                exp--;
                if(exp <= 0)
                {
                    Level--;
                    exp = Threshhold*Level-1;
                }
            }
        }
        #region Opps
        public static TrainedStat operator ++(TrainedStat a)
        {
            a.Add();
            return a;
        }
        public static TrainedStat operator +(TrainedStat a, int b)
        {
            a.Add(b);
            return a;
        }
        public static TrainedStat operator -(TrainedStat a, int b)
        {
            a.Subtract(b);
            return a;
        }
        public static TrainedStat operator --(TrainedStat a)
        {
            a.Subtract();
            return a;
        }
        #endregion

        public override string ToString()
        {
            return Level.ToString();
        }
    }
}
