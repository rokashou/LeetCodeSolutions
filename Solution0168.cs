/*
Aug 22, 2023 22:33
Runtime 61 ms Beats 88.10%
Memory 36.9 MB Beats 15.65%
*/


public class Solution {
    public string ConvertToTitle(int columnNumber) {
        var AZ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var result = new StringBuilder();
        while (columnNumber > 0)
        {
            columnNumber--;
            var remainder = columnNumber % 26;
            result.Insert(0, AZ[remainder]);
            columnNumber = columnNumber / 26;
        }

        return result.ToString();
    }
}
