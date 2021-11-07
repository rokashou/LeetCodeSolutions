/*
Uploaded: 10/04/2021 22:16
Runtime: 173 ms, 17.31% faster
Memory Usage: 26.7 MB, 97.12 less
*/

public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1) return s;

        string ret=string.Empty;
        int n = s.Length;
        int cycleLen = 2 * numRows - 2;

        for(int i = 0; i<numRows; i++){
            for(int j=0;j + i < n; j += cycleLen){
                ret += s[j+i];
                if(i!=0 && i != numRows - 1 && j + cycleLen - i < n)
                    ret += s[j + cycleLen - i];
            }
        }

        return ret;

    }
}
