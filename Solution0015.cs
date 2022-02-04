/*
Runtime: 210 ms, faster than 64.66% of C# online submissions for 3Sum.
Memory Usage: 48.3 MB, less than 26.92% of C# online submissions for 3Sum.
Uploaded: 02/05/2022 00:43
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort<int>(nums);
        List<IList<int>> result = new List<IList<int>>();

        if (nums.Length < 3) return result;

        for (int i = 0; i < nums.Length;i++){
            if(i>0 && nums[i-1]==nums[i]) continue;

            int first = nums[i];
            int l = i + 1;
            int r = nums.Length - 1;

            while(l < r){
                int threeSum = first + nums[l] + nums[r];
                if(threeSum > 0){
                    r--;
                }
                else if(threeSum < 0){
                    l++;
                }
                else{
                    result.Add(new List<int> { first, nums[l], nums[r] });
                    l++;
                    while(l<r && nums[l-1] == nums[l]) l++;
                }
            }
        }

        return result;
    }
}
