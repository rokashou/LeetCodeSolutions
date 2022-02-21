/*
Runtime: 138 ms, faster than 57.64% of C# online submissions for Majority Element.
Memory Usage: 40.8 MB, less than 49.78% of C# online submissions for Majority Element.
Uploaded: 02/22/2022 00:37
*/

public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int? candidate = null;

        foreach(var i in nums){
            if(count == 0) candidate = i;
            count += (i == candidate) ? 1 : -1;
        }

        return candidate.Value;
    }
}



/*
Runtime: 162 ms
Memory Usage: 40.6 MB
Uploaded: 02/22/2022 00:29	
*/
public class Solution169{
    public int MajorityElement(int[] nums)
    {
        Array.Sort<int>(nums);
        return nums[nums.Length / 2];
    }
}
