/*
Official Solution
Runtime: 88 ms, faster than 95.22% of C# online submissions for Search in Rotated Sorted Array II.
Memory Usage: 41.4 MB, less than 17.83% of C# online submissions for Search in Rotated Sorted Array II.
Uploaded: 03/29/2022 00:25	
*/


public class Solution {
    public bool Search(int[] nums, int target)
    {
        int n = nums.Length;
        if(n==0) return false;

        int end = n - 1;
        int start = 0;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(nums[mid] == target){
                return true;
            }

            if(!IsBinarySearchHelphul(nums, start, nums[mid])){
                start++;
                continue;
            }
            // which array does pivot belong to
            bool pivotArray = ExistsInFirst(nums, start, nums[mid]);

            // which array does target belong to
            bool targetArray = ExistsInFirst(nums, start, target);
            if(pivotArray ^ targetArray) {
                // if pivot and target exist in different sorted arrays,
                // recall that xor is true when both operands are distinct.
                if(pivotArray){
                    start = mid + 1; // pivot in the first, target in the 2nd
                }else{
                    end = mid - 1; // target in the first, pivot in the 2nd
                }                    
            }else{
                // if pivot and target exist in same sorted array
                if(nums[mid] < target){
                    start = mid + 1;
                }else{
                    end = mid - 1;
                }
            }
        }
        return false;
    }

    // returns true if we can reduce the search space in current binary search space
    private bool IsBinarySearchHelphul(int[] arr, int start, int element){
        return arr[start] != element;
    }

    // retruns true if element exists in first array, false if it exists in second
    private bool ExistsInFirst(int[] arr, int start, int element){
        return arr[start] <= element;
    }
}

