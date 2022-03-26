/*
Runtime: 187 ms, faster than 34.31% of C# online submissions for Binary Search.
Memory Usage: 42.9 MB, less than 40.07% of C# online submissions for Binary Search.
Uploaded: 03/26/2022 18:48
*/

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while(left<=right){
            int mid = (left + right) / 2;
            if(nums[mid]==target) return mid;

            if(nums[mid] > target){
                right = mid-1;
            }else{
                left = mid+1;
            }
        }

        return -1;
    }
}


