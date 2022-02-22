/*
Runtime: 94 ms, faster than 44.73% of C# online submissions for Excel Sheet Column Number.
Memory Usage: 36.4 MB, less than 61.00% of C# online submissions for Excel Sheet Column Number.
Uploaded: 02/22/2022 22:43
*/


public class Solution {
    public int TitleToNumber(string columnTitle) {
        int result = 0;
        foreach(char ch in columnTitle){
            result *= 26;
            result += ch - 'A' +1;
        }
        return result;

    }
}
