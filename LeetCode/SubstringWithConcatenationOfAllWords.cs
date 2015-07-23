using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SubstringWithConcatenationOfAllWords
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var locations = new Dictionary<int, HashSet<int>>();
            var size = words.Length;
            // Map
            for (var i = 0; i < size; i++)
            {
                var word = words[i];
                var location = 0;
                while ((location = s.IndexOf(word, location, StringComparison.Ordinal)) != -1)
                {
                    var set = locations.GetOrDefault(location, _ => new HashSet<int>());
                    set.Add(i);
                }
            }

            // Search
            var contains = new bool[size];
            foreach (var location in locations.OrderBy(pair => pair.Key))
            {
                Array.Clear(contains, 0, size);
            }
        }
    }

    public static class DictionaryExts
    {
        public static TValue GetOrDefault<TKey, TValue>(
            this Dictionary<TKey, TValue> dict,
            TKey key,
            Func<TKey, TValue> valueGenerator = null)
        {
            if (valueGenerator == null)
            {
                valueGenerator = _ => default(TValue);
            }
            TValue value;
            if (!dict.TryGetValue(key, out value))
            {
                value = valueGenerator(key);
                dict[key] = value;
            }
            return value;
        }
    }
}