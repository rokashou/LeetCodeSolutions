/*
Jun 27, 2023 23:28
Runtime 373 ms Beats 81.18%
Memory 64.6 MB Beats 69.41%
*/

public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        int m = nums1.Length;
        int n = nums2.Length;

        var ans = new List<IList<int>>();
        var visited = new HashSet<(int, int)>();

        var minHeap = new PriorityQueue<int[], int>();
        minHeap.Enqueue(new int[] { 0, 0 }, nums1[0] + nums2[0]);
        visited.Add((0, 0));

        while(k-- > 0 && minHeap.Count > 0) {
            int[] top = minHeap.Dequeue();
            int i = top[0];
            int j = top[1];

            var tmp = new List<int>();
            tmp.Add(nums1[i]);
            tmp.Add(nums2[j]);
            ans.Add(tmp);

            if(i+1 < m && !visited.Contains((i + 1, j))) {
                minHeap.Enqueue(new int[] { i + 1, j }, nums1[i + 1] + nums2[j]);
                visited.Add((i + 1, j));
            }

            if(j+1 < n && !visited.Contains((i, j + 1))){
                minHeap.Enqueue(new int[] { i, j + 1 }, nums1[i] + nums2[j + 1]);
                visited.Add((i, j + 1));
            }

        }
        return ans;
    }
}
