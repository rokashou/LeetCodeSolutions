/*
Runtime: 143 ms, faster than 79.84% of C# online submissions for Merge Sorted Array.
Memory Usage: 41.2 MB, less than 82.87% of C# online submissions for Merge Sorted Array.
Uploaded: 05/09/2022 22:07
*/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        while(m > 0 && n > 0)
        {
            // check the order of nums1[m-1] and nums2[n-1]
            // the lager one goes to nums[m+n-1]
            // and set the lager one index -= 1;
            if(nums1[m-1] > nums2[n - 1])
            {
                nums1[m + n - 1] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }
        }
        
        if(m == 0)
        {
            while (n > 0) { 
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }
        }
    }
}


