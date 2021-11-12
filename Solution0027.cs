/*
Uploaded: 11/13/2021 00:26
Runtime: 128 ms, faster than 70.13% of C# online submissions for Remove Element.
Memory Usage: 40.8 MB, less than 20.64% of C# online submissions for Remove Element.
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        for(int idx=0;idx < nums.Length;idx++){
            if(nums[idx] != val) {
                if(idx!=count){
                    nums[count]=nums[idx];
                }
                count++;
            }
        }
        return count;

    }
}
