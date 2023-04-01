/*
    Url: https://leetcode.com/problems/consecutive-characters/
    Uploaded: 12/14/2021 07:31
    Runtime: 68 ms, faster than 79.25% of C# online submissions for Consecutive Characters.
    Memory Usage: 36.5 MB, less than 75.47% of C# online submissions for Consecutive Characters.
*/

public class Solution {
    public int MaxPower(string s) {
        int result=1;
        int count=1;
        for(int i=1;i<s.Length;i++){
            if(s[i]==s[i-1]) 
                count++;
            else
                count=1;
            if(count>result){
                result=count;
            }
        }
        return result;
    }
}
