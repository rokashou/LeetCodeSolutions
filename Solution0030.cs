/*
Runtime 277 ms, Beats 82.88%
Memory 59.2 MB, Beats 27.40%
Accepted Feb 04, 2023 01:31
*/

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if (!counts.TryAdd(word, 1))
                counts[word] = counts[word] + 1;
        }
        List<int> indexes = new List<int>();
        int n = s.Length, num = words.Length, len = words[0].Length;
        for(int i = 0; i < n - num * len + 1; i++)
        {
            var seen = new Dictionary<string, int>();
            int j = 0;
            while (j < num)
            {
                string word = s.Substring(i + j * len, len);
                if (counts.ContainsKey(word))
                {
                    if (!seen.TryAdd(word, 1))
                        seen[word] = seen[word] + 1;
                    if (seen[word] > counts.GetValueOrDefault(word, 0))
                        break;
                }
                else
                    break;

                j++;
            }
            if (j == num)
            {
                indexes.Add(i);
            }
        }
        return indexes;
    }
}
