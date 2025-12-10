using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSum
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }
            var characters_s = new Dictionary<char, int>();
            var characters_t = new Dictionary<char, int>();

            foreach (var val in s)
            {
                characters_s[val] = characters_s.GetValueOrDefault(val) + 1;
            }

            foreach (var val in t)
            {
                characters_t[val] = characters_t.GetValueOrDefault(val) + 1;
            }

            // var result = characters_s.OrderBy(kvp => kvp.Key)
            //     .SequenceEqual(characters_t.OrderBy(kvp => kvp.Key));


            foreach (var kvp in characters_s)
            {
                char character = kvp.Key;
                int sCount = kvp.Value;

                // Check if the character exists in tMap AND if the counts match.
                // If EITHER condition fails, they are not anagrams.
                if (!characters_t.TryGetValue(character, out int tCount) || sCount != tCount)
                {
                    return false;
                }
            }

            // If all checks pass, they are anagrams.
            return true;
            // Console.WriteLine($"Result = {result}");

            //return result;
        }
    }
}
