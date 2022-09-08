/*
Runtime: 51 ms, faster than 63.06% of C# online submissions for Strictly Palindromic Number.
Memory Usage: 27 MB, less than 57.66% of C# online submissions for Strictly Palindromic Number.
Uploaded: 09/08/2022 23:31
*/

public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        bool result=false;
        for(int i=n-2;i>=2;i--){
            result = IsPalindromicByBase(n,i);
            if(result == false) return false;
        }
        return true;
    }
    
    public bool IsPalindromicByBase(int n, int b) {
        string pString = "";
        while(n > 0){
            pString += (n % b).ToString();
            n /= b;
        }
        return IsPalindromicString(pString);
    }
    
    public bool IsPalindromicString(string s){
        for(int i=0;i<s.Length/2;i++){
            if(s[i] != s[s.Length-i-1]) return false;
        }
        return true;
    }
}
