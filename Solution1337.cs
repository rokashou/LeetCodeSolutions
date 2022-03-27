/*
Runtime: 420 ms, faster than 5.39% of C# online submissions for The K Weakest Rows in a Matrix.
Memory Usage: 45.1 MB, less than 10.18% of C# online submissions for The K Weakest Rows in a Matrix.
Uploaded: 03/27/2022 15:00
*/



public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        
        SortedDictionary<int, List<int>> matMap = new SortedDictionary<int, List<int>>();

        for (int idx = 0; idx < mat.Length;idx++){
            int strong = CountRowStrong(mat[idx]);
            if(matMap.ContainsKey(strong)){
                matMap[strong].Add(idx);
            }else{
                List<int> v = new List<int>();
                v.Add(idx);
                matMap.Add(strong, v);
            }
        }

        List<int> ans = new List<int>();
        foreach(int key in matMap.Keys){
            if(ans.Count < k){
                ans.AddRange(matMap[key]);
            }
            else break;
        }

        if(ans.Count > k){
            ans.RemoveRange(k, ans.Count - k);
        }

        return ans.ToArray();
    }

    int CountRowStrong(int[] row){
        int count = 0;
        foreach(int i in row){
            if(i>0) count++;
        }
        return count;
    }
}

