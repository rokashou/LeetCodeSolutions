/*
Runtime: 153 ms, faster than 54.29% of C# online submissions for Number of Lines To Write String.
Memory Usage: 38.7 MB, less than 100.00% of C# online submissions for Number of Lines To Write String.
Uploaded: 01/25/2022 21:41
*/

public class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        int[] result = new int[2];
        result[0]=1;
        foreach(var ch in s){
            result[1] += widths[ch - 'a'];
            if(result[1] > 100){
                result[0]++;
                result[1]=widths[ch - 'a'];
            }
        }
        return result;
    }
}

