/*
May 05, 2023 22:59
Runtime 80 ms Beats 67.74%
Memory 42 MB Beats 58.6%
*/

public class Solution {
    public int MaxVowels(string s, int k) {
        int cnt = 0, max = 0;
        for(int i = 0; i < k; i++)
        {
            if (s[i]=='a' || s[i]=='e' || s[i]=='i' || s[i]=='o' || s[i]=='u')
                cnt++;
        }

        if (cnt == k) return k;
        max = cnt;

        for (int i = k; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                cnt++;
            }
            if (s[i - k] == 'a' || s[i - k] == 'e' || s[i - k] == 'i' || s[i - k] == 'o' || s[i - k] == 'u')
            {
                cnt--;
            }
            max = Math.Max(max, cnt);
            if (max == k) return k;
        }

        return max;        
    }
}
