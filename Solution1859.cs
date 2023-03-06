/*
Mar 06, 2023 23:34
Runtime 72 ms, Beats 95.56%
Memory 36.8 MB, Beats 51.67%
*/

public class Solution {
    public string SortSentence(string s) {
        var pq = new PriorityQueue<string, int>();
        var arr = s.Split(" ");
        foreach (var v in arr)
        {
            pq.Enqueue(v.Substring(0, v.Length - 1), (int)(v[v.Length - 1] - '0'));
        }
        string ans = pq.Dequeue();
        while (pq.Count > 0) { ans += " " + pq.Dequeue(); }
        return ans;
    }
}

