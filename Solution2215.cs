/*
May 03, 2023 20:45
Runtime 176 ms Beats 71.25%
Memory 56.5 MB Beats 81.25%
*/

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var ans = new List<IList<int>>();

        HashSet<int> hs1 = new HashSet<int>(nums1);
        HashSet<int> hs2 = new HashSet<int>(nums2);

        hs1.ExceptWith(hs2);
        hs2.ExceptWith(nums1);

        ans.Add(new List<int>(hs1));
        ans.Add(new List<int>(hs2));

        return ans;
    }
}

