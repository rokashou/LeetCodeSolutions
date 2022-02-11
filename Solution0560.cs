/*
Runtime: 184 ms, faster than 63.39% of C# online submissions for Subarray Sum Equals K.
Memory Usage: 43.3 MB, less than 31.16% of C# online submissions for Subarray Sum Equals K.
Uploaded: 02/11/2022 22:45

Official Solution 4. HashMap

*/

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0, sum = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        map.Add(0, 1);
        for (int i = 0; i < nums.Length;i++){
            sum += nums[i];
            if(map.ContainsKey(sum - k)){
                count += map[sum - k];
            }
            
            if(map.ContainsKey(sum)){
                map[sum] = map[sum]+1;
            }else{
                map.Add(sum,1);
            }
        }
        return count;
    }
}
