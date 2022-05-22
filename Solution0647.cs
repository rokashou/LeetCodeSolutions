/*
Runtime: 69 ms, faster than 80.51% of C# online submissions for Palindromic Substrings.
Memory Usage: 36.3 MB, less than 34.32% of C# online submissions for Palindromic Substrings.
Uploaded: 05/22/2022 16:28
*/

public class Solution {
    public int CountSubstrings(string s) {
        int len = s.Length, ans = 0;
        for(int i = 0; i < len; i++)
        {
            int j = i - 1, k = i;
            while (k < len - 1 && s[k] == s[k + 1]) k++;
            ans += (k - j) * (k - j + 1) / 2;
            i = k++;
            while (j >= 0 && k < len && s[k++] == s[j--]) ans++;
        }
        return ans;

    }
}
