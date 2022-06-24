/*
Runtime: 245 ms, faster than 50.00% of C# online submissions for Construct Target Array With Multiple Sums.
Memory Usage: 44.4 MB, less than 50.00% of C# online submissions for Construct Target Array With Multiple Sums.
Uploaded: 06/24/2022 22:01
*/


public class Solution {
    public bool IsPossible(int[] target) {
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
        long sum = 0;
        foreach(int x in target)
        {
            sum += x;
            pq.Enqueue(x, -x);
        }
        while(sum > 1 && pq.Peek() > sum/2)
        {
            int cur = pq.Dequeue();
            sum -= cur;
            if (sum <= 1)
                return sum == 0 ? false : true;

            int tmp = cur % (int)sum;
            sum += tmp;
            pq.Enqueue(tmp,-tmp);
        }
        return sum == target.Length;
    }
}
