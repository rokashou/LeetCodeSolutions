/*
Runtime 153 ms Beats 28.77% of users with C#
Memory 70.21 MB Beats 45.89% of users with C#
*/

public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        string[] result = new string[score.Length];
        for(int i=0;i<score.Length;i++){
            pq.Enqueue(i, -1*score[i]);
        }
        int ranks = 0;
        while(pq.Count > 0){
            ranks++;
            int index = pq.Dequeue();
            switch(ranks){
                case 1:
                    result[index] = "Gold Medal";
                    break;
                case 2:
                    result[index] = "Silver Medal";
                    break;
                case 3:
                    result[index] = "Bronze Medal";
                    break;
                default:
                    result[index] = ranks.ToString();
                    break;
            }
        }
        return result;        
    }
}
