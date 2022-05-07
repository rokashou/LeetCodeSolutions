/*
Runtime: 66 ms, faster than 86.64% of C# online submissions for Implement strStr().
Memory Usage: 36.1 MB, less than 61.51% of C# online submissions for Implement strStr().
Uploaded: 05/07/2022 21:46
*/


public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) return 0;
        if (needle.Length > haystack.Length) return -1;

        int idx1 = 0, idx2 = 0;
        while(idx1 + needle.Length <= haystack.Length)
        {
            for(idx2 = 0;idx2 < needle.Length; idx2++)
            {
                if(haystack[idx1+idx2] != needle[idx2])
                {
                    idx1 += 1;
                    idx2 = -1;
                    break;
                }
            }
            if (idx2 == -1)
                continue;
            else
                return idx1;
        }
        return -1;

    }
}

