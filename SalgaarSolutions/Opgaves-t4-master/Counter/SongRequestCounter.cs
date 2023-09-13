using System.Collections.Concurrent;

namespace Opgavesæt4.Counter
{
    public class SongRequestCounter
    {
        private static readonly ConcurrentDictionary<string, int> CounterDictionary = new ConcurrentDictionary<string, int>();

        public static void IncrementCounter(string songPath)
        {
            // Tjekker om songPath allerede eksisterer i dictionnary, og hvis det ikke gør, initialiseres det til 1.
            CounterDictionary.AddOrUpdate(songPath, 1, (_, currentValue) => currentValue + 1);
        }

        public static int GetCounter(string songPath)
        {
            if (CounterDictionary.TryGetValue(songPath, out var count))
            {
                return count;
            }

            // Ellers returner 0.
            return 0;
        }
    }
}
