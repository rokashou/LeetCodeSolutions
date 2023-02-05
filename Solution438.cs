/*
Runtime 135 ms, Beats 89.15%
Memory 46.9 MB, Beats 50.39%
Accept Feb 06, 2023 00:57
*/

public class Solution {
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> result = new List<int>();
        if (s.Length < p.Length) return result;

        int s_len = s.Length;
        int p_len = p.Length;

        //Dictionary<char,int> count = new Dictionary<char, int>();
        int[] freq_p = new int[26];
        int[] window = new int[26];

        // first window
        for (int i = 0; i < p_len; i++)
        {
            freq_p[p[i] - 'a']++;
            window[s[i] - 'a']++;
        }

        if (CheckArrayEquals(freq_p, window)) result.Add(0);

        for(int i = p_len; i < s_len; i++)
        {
            window[s[i - p_len] - 'a']--;
            window[s[i] - 'a']++;

            if (CheckArrayEquals(freq_p, window)) result.Add(i - p_len + 1);
        }

        return result;
    }

    private bool CheckArrayEquals(int[] a, int[] b)
    {
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
