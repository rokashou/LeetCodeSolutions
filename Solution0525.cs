/*
Runtime: 196 ms, faster than 100.00% of C# online submissions for Contiguous Array.
Memory Usage: 47.3 MB, less than 8.05% of C# online submissions for Contiguous Array.
Uploaded: 02/04/2022 20:37
*/


public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, -1);
        int maxlen = 0, count = 0;
        for (int i = 0; i < nums.Length;i++){
            count = count + (nums[i] == 1 ? 1 : -1);
            if(dict.ContainsKey(count)){
                maxlen = Math.Max(maxlen, i - dict[count]);
            }else{
                dict.Add(count, i);
            }
        }
        return maxlen;

    }
}

