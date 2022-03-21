/*
Runtime: 120 ms, faster than 90.29% of C# online submissions for Partition Labels.
Memory Usage: 42.8 MB, less than 17.23% of C# online submissions for Partition Labels.
Uploaded: 03/21/2022 15:53
*/


public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] last = new int[26];
        int i, j;
        for(i=0;i<s.Length;i++){
            last[s[i] - 'a'] = i;
        }

        int anchor = 0;
        List<int> ans = new List<int>();
        for (i = 0, j = 0; i < s.Length;i++){
            j = Math.Max(j, last[s[i] - 'a']);
            if(i==j){
                ans.Add(i - anchor + 1);
                anchor = i + 1;
            }
        }

        return ans;
    }
}

