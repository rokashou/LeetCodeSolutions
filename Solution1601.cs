/*
Jul 02, 2023 21:31
Runtime 106 ms Beats 100%
Memory 38.6 MB Beats 100%
*/

public class Solution {
    private int answer = 0;

    private void MaxRequest(int[][] requests, int[] indegree, int n, int index, int count) {
        if(index == requests.Length) {
            // Check if all buildings have an in-degree of 0.
            for (int i = 0; i < n; i++)
                if (indegree[i] != 0) return;

            answer = Math.Max(answer, count);
            return;
        }

        // Consider this reqest, increment and decrement for the buildiings involved.
        indegree[requests[index][0]]--;
        indegree[requests[index][1]]++;
        // Move on to the next request and also increment the count of requests.
        MaxRequest(requests, indegree, n, index + 1, count + 1);
        // Backtrack to the previous values to move back to the original state before the second recursion.
        indegree[requests[index][0]]++;
        indegree[requests[index][1]]--;

        // Ignore this request and move on to the next request without incrementing the count.
        MaxRequest(requests, indegree, n, index + 1, count);
    }

    public int MaximumRequests(int n, int[][] requests)
    {
        int[] indegree = new int[n];
        MaxRequest(requests, indegree, n, 0, 0);

        return answer;
    }
}
