namespace Better_Stats
{
    public struct ModdedStat
    {
        public int value;
        public double Modifier;

        public ModdedStat(int v)
        {
            value = v;
            Modifier = 1;
        }

        public static implicit operator int(ModdedStat stat) => (int)(stat.value * stat.Modifier);
        public static implicit operator ModdedStat(int v) => new ModdedStat(v);

        public static ModdedStat operator++(ModdedStat v)
        {
            v.value++;
            return v;
        }
        public static ModdedStat operator--(ModdedStat v)
        {
            v.value--;
            return v;
        }
        public static ModdedStat operator +(ModdedStat v, int x)
        {
            v.value+=x;
            return v;
        }
        public static ModdedStat operator -(ModdedStat v, int x)
        {
            v.value-=x;
            return v;
        }
        public static ModdedStat operator +(ModdedStat v, double x)
        {
            v.Modifier+=x;
            return v;
        }
        public static ModdedStat operator -(ModdedStat v, double x)
        {
            v.Modifier-=x;
            return v;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
