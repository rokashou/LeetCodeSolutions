/*
Runtime: 164 ms, faster than 16.81% of C# online submissions for Find the Difference.
Memory Usage: 38.3 MB, less than 43.10% of C# online submissions for Find the Difference.
Uploaded: 02/07/2022 22:01
*/


public class Solution {
    public char FindTheDifference(string s, string t) {
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        Array.Sort<char>(s1);
        Array.Sort<char>(t1);
        int i=0;
        for (; i < s.Length;i++){
            if(s1[i]!=t1[i]) return t1[i];
        }
        return t1[i];
    }
}
