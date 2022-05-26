/*
Runtime: 125 ms, faster than 34.38% of C# online submissions for Final Value of Variable After Performing Operations.
Memory Usage: 38.3 MB, less than 68.53% of C# online submissions for Final Value of Variable After Performing Operations.
Uploaded: 05/26/2022 20:59
*/

public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach(string s in operations)
        {
            if (s[1] == '+')
                x++;
            else
                x--;
        }
        return x;
    }
}
