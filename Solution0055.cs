/*
Uploaded: 10/03/2021 15:21
Runtime: 164 ms, 88.24%
Memory Usage: 40.2 MB, 67.01%
*/

public class Solution {
    public bool CanJump(int[] nums)
    {
        // When the Array is less then 1 item, whatever it will be true
        if (nums.Length <= 1) return true;

        int lastIndex = nums.Length - 1;

        while (true)
        {
            int newTarget = 0;
            for(newTarget = lastIndex - 1; newTarget >= 0; newTarget--)
            {
                if (nums[newTarget] + newTarget >= lastIndex) break;
            }
            if (newTarget >= 0)
                lastIndex = newTarget;
            else 
                return false;

            if (lastIndex <= 0) return true;
            if(newTarget == 0)
                return true;

        }
    }
}
