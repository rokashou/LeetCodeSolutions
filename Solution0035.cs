/*
Uploaded: 11/26/2021 22:13
Runtime: 170 ms, faster than 5.10% of C# online submissions for Search Insert Position.
Memory Usage: 36.7 MB, less than 61.77% of C# online submissions for Search Insert Position.
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int lo=0,hi=nums.Length-1;
        if(nums[0] >= target) return 0;
        if(nums[hi] < target) return hi+1;
        while(hi>=lo){
            int mid = (hi+lo)/2;
            if(nums[mid]>target){
                hi=mid-1;
            }else if(nums[mid]<target){
                lo=mid+1;
            }else{
                return mid;
            }
        }
        
        return lo;
    }
}
