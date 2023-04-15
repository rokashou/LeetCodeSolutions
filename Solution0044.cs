/*
Two pointer
Apr 15, 2023 12:38
Runtime 89 ms Beats 64.4%
Memory 47.2 MB Beats 81.46%
*/

public class Solution {
    public bool IsMatch(string s, string p) {
        int i = 0, j = 0, match = 0, AstIdx = -1;
        while(i < s.Length)
        {
            if (j < p.Length && (p[j] == '?' || s[i] == p[j]))
            {
                // advancing both pointers
                i++; j++;
                continue;
            }

            if (j < p.Length && p[j] == '*')
            {
                // found *, only advancing pattern pointer
                AstIdx = j;
                match = i;
                j++;
                continue;
            }

            if (AstIdx != -1)
            {
                // last pattern pointer was *, advancing string pointer
                j = AstIdx + 1;
                match++;
                i = match;
                continue;
            }

            // current pattern point is not *, last pattern point was not * characters do not match
            return false;
        }
        // check for remaining characters in pattern
        while (j < p.Length && p[j] == '*') j++;

        return j == p.Length;
    }
}
