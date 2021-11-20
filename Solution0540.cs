/*
540. Single Element in a Sorted Array
https://leetcode.com/problems/single-element-in-a-sorted-array/

Uploaded: 11/20/2021 20:47
Runtime: 96 ms, faster than 54.68% of C# online submissions for Single Element in a Sorted Array.
Memory Usage: 39.5 MB, less than 6.40% of C# online submissions for Single Element in a Sorted Array.
*/

public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int low=0;
        int high=nums.Length-1;
        while(high > low){
            int mid=(high+low)/2;
            if(nums[mid]!=nums[mid+1]){
                if(nums[mid]!=nums[mid-1]) return nums[mid];
                
                if((high-mid)%2 == 0){
                    high=mid;
                }
                else{
                    low=mid+1;
                }
            }else{
                if((mid-low)%2 == 0){
                    low=mid+2;
                }else{
                    high=mid-1;
                }
            }
        }
        return nums[high];

    }
}
