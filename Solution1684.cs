/*
Apr 11, 2023 23:00
Runtime 105 ms, Beats 98.55%
Memory 50.9 MB, Beats 89.13%
*/

public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int result = 0;
        bool flag = false;
        foreach(var word in words)
        {
            flag = true;
            foreach(var ch in word)
            {
                if(allowed.IndexOf(ch) == -1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag) result++;
        }
        return result;
    }
}
