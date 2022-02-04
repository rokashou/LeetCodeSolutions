/*
Official Solution 4: Binary Search

Runtime: 96 ms, faster than 88.54% of C# online submissions for Longest Common Prefix.
Memory Usage: 40.7 MB, less than 7.89% of C# online submissions for Longest Common Prefix.
Uploaded: 02/04/2022 23:41

*/

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if(strs == null || strs.Length == 0) return "";
        int minLen = int.MaxValue;
        foreach(string str in strs){
            minLen = Math.Min(minLen, str.Length);
        }
        int low = 1;
        int high = minLen;
        while(low <= high){
            int middle = (low + high) / 2;
            if(IsCommonPrefix(strs, middle)){
                low = middle + 1;
            }else{
                high = middle - 1;
            }
        }
        return strs[0].Substring(0, (low + high) / 2);
    }

    private bool IsCommonPrefix(string[] strs, int len){
        string str1 = strs[0].Substring(0, len);
        for (int i = 1; i < strs.Length;i++){
            if(!strs[i].StartsWith(str1)) return false;
        }
        return true;
    }

}
