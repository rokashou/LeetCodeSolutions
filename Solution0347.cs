// Solution with HEAP and PriorityQueue, where the PriorityQuere is new feature in net 6(C# 11)
/*
Runtime: 181 ms, faster than 74.85% of C# online submissions for Top K Frequent Elements.
Memory Usage: 44.2 MB, less than 94.68% of C# online submissions for Top K Frequent Elements.
Uploaded: 04/10/2022 02:23
*/

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // O(1) time
        if(k==nums.Length){
            return nums;
        }

        // 1. build hash map: character and how often it appears
        // O(N) time
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach(int n in nums){
            int va = count.GetValueOrDefault(n, 0);
            if(count.ContainsKey(n)){
                count[n] = va + 1;
            }else{
                count.Add(n, 1);
            }
        }

        // init heap 'the less frequent element first'
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach(var key in count.Keys){
            heap.Enqueue(key, count[key]);
            // 2.keep k top frequent elements in the heap
            // O(N log k) < O(N log N) time
            if(heap.Count > k) heap.Dequeue();
        }

        // 3.build an output array
        // O(k log k) time
        int[] top = new int[k];
        for (int i = k - 1; i >= 0;i--){
            top[i] = heap.Dequeue();
        }

        return top;
    }
}

