/*
Runtime: 153 ms, faster than 96.03% of C# online submissions for Cells in a Range on an Excel Sheet.
Memory Usage: 53.5 MB, less than 10.32% of C# online submissions for Cells in a Range on an Excel Sheet.
Uploaded: 09/26/2022 23:32
*/


public class Solution {
    public IList<string> CellsInRange(string s) {
        IList<string> result = new List<string>();
        int c1 = s[0] - 'A';
        int r1 = s[1] - '0';
        int c2 = s[3] - 'A';
        int r2 = s[4] - '0';
        for (int c = c1; c <= c2; c++)
            for (int r = r1; r <= r2; r++)
            {
                string tmp = "" + (char)('A' + c) + (char)('0' + r);
                result.Add(tmp);
            }

        return result;
    }
}

