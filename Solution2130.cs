/*
May 17, 2023 21:00
Runtime 295 ms Beats 27.43%
Memory 55.3 MB Beats 76.99%
*/

public class Solution {
    public int PairSum(ListNode head) {
        List<int> list = new List<int>();
        var node = head;
        while (node != null)
        {
            list.Add(node.val);
            node = node.next;
        }
        int max = 0;
        int n = list.Count;
        for(int i = 0; i < n / 2; i++)
        {
            max = Math.Max(list[i] + list[n - i - 1], max);
        }
        return max;        
    }
}
