using System.Collections.Concurrent;

namespace Opgavesæt4.Counter
{
    public class AlbumRequestCounter
    {
        private static readonly ConcurrentDictionary<string, int> CounterDictionary = new ConcurrentDictionary<string, int>();

        public static void IncrementCounter(string albumPath)
        {
            CounterDictionary.AddOrUpdate(albumPath, 1, (_, currentValue) => currentValue + 1);
        }

        public static int GetCounter(string albumPath)
        {
            if (CounterDictionary.TryGetValue(albumPath, out var count))
            {
                return count;
            }

            return 0;
        }
    }
}
