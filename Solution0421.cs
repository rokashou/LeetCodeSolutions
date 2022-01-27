/*
Runtime: 359 ms, faster than 50.00% of C# online submissions for Maximum XOR of Two Numbers in an Array.
Memory Usage: 50 MB, less than 57.89% of C# online submissions for Maximum XOR of Two Numbers in an Array.
Uploaded: 01/27/2022 21:33
*/

public class Solution {
    public int FindMaximumXOR(int[] nums) {
        int res = 0;
        int mask = 0;
        for (int i = 31; i >= 0;--i){
            mask |= (1 << i);
            HashSet<int> st=new HashSet<int>();
            foreach(int nm in nums) st.Add(nm & mask);
            int t = res | (1 << i);
            foreach(int prefix in st){
                if(st.Contains(t ^ prefix)){
                    res = t;
                    break;
                }
            }
        }
        return res;
    }
}
