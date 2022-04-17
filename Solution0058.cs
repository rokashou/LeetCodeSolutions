/*
Runtime: 69 ms, faster than 73.95% of C# online submissions for Length of Last Word.
Memory Usage: 36.5 MB, less than 22.05% of C# online submissions for Length of Last Word.
Uploaded: 04/17/2022 23:19
*/

public class Solution {
    public int LengthOfLastWord(string s)
    {
        string[] sp = s.Trim().Split(' ');
        return sp[sp.Length-1].Length;
    }
}



/*
Runtime: 68 ms, faster than 75.55% of C# online submissions for Length of Last Word.
Memory Usage: 36.3 MB, less than 23.38% of C# online submissions for Length of Last Word.
Uploaded: 04/17/2022 23:26
*/

public class Solution58_Ap02
{
    public int LengthOfLastWord(string s)
    {
        int idx = s.Length - 1;
        while (s[idx] == ' ') idx--;
        int count = 0;
        while ((idx-count >=0) && s[idx - count] != ' ') count++;
        return count;
    }
}


 
