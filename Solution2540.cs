/*

Runtime 226 ms Beats 85.19%
Memory 66.17 MB Beats 34.57%
Upload: Mar 09, 2024 11:16
*/

public class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;){
            if (nums1[i] == nums2[j])
                return nums1[i];
            if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                i++;
            }
        }
        return -1;
    }
}
