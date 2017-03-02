using System.Collections.Generic;

namespace System.Linq.System.Linq
{
    public static partial class Enumerable
    {
        public static void Exit<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach(TSource element in source)
            {
                if (predicate(element) == true)
                    Environment.Exit(0);
            }

            Environment.Exit(1);
        }
    }
}
