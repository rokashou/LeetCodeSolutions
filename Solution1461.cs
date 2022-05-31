/*
Runtime: 362 ms, faster than 11.11% of C# online submissions for Check If a String Contains All Binary Codes of Size K.
Memory Usage: 68.1 MB, less than 11.11% of C# online submissions for Check If a String Contains All Binary Codes of Size K.
Uploaded: 05/31/2022 20:48
*/

public class Solution {
    public bool HasAllCodes(string s, int k) {
        int need = 1 << k;
        HashSet<string> got = new HashSet<string>();

        for(int i = k; i <= s.Length; i++)
        {
            string a = s.Substring(i - k, k);
            if (!got.Contains(a))
            {
                got.Add(a);
                need--;
                // return true when found all occurrences
                if(need == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
