namespace Praktikum02.Blasor.Data
{
    public static class GetRandom
    {
        private static readonly Random r = Random.Shared;

        public static int Int32(int min = int.MinValue, int max = int.MaxValue)
        {
            if (min == max) return min;
            if (min > max) (min, max) = (max, min);
            return r.Next(min, max);
        }
    }
}
