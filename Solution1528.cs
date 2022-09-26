/*
Runtime: 103 ms, faster than 98.95% of C# online submissions for Shuffle String.
Memory Usage: 42.6 MB, less than 11.89% of C# online submissions for Shuffle String.
Uploaded: 09/26/2022 23:18
*/

public class Solution {
    public string RestoreString(string s, int[] indices) {
        var result = new char[s.Length];
        for(int i = 0; i < indices.Length; i++)
        {
            result[indices[i]] = s[i];
        }
        return new string(result);
        
    }
}
