/*
Uploaded: 12/25/2021 00:03

Runtime: 148 ms, faster than 37.80% of C# online submissions for Merge Intervals.
Memory Usage: 43.5 MB, less than 37.29% of C# online submissions for Merge Intervals.
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => {return a[0]-b[0];});
        List<int[]> merged = new List<int[]>();
        foreach(var interval in intervals){
            if(merged.Count == 0  || merged[merged.Count-1][1] < interval[0]){
                merged.Add(interval);
            }
            else{
                merged[merged.Count-1][1] = Math.Max(merged[merged.Count-1][1],interval[1]);
            }
        }
        return merged.ToArray();        
    }
}

