public class Solution {

    // string solution
    /*
        Uploaded: 10/10/2021 19:47 
        Runtime: 48 ms, 89.27%
        Memory Usage: 33 MB
    */
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        string origin = x.ToString();
        string reverseX = string.Empty;
        int length = origin.Length;

        for(int i=length-1;i>=0;i--){
            reverseX += origin[i];
        }

        return origin.Equals(reverseX);
    }

    // No string solution
    /* 
        Uploaded: 10/10/2021 20:06
        
        Runtime: 56 ms, 71.04%
        Memory Usage: 29.6 MB, 32.11%
        
    */
    public bool IsPalindrome2(int x){

        // if the number < 0, it fail.
        // if the last digit is 0, it fail too.
        // 0 ~ 9 is good.
        if(x<0) return false;
        if(x<10) return true;
        if(x%10 == 0) return false;

        int rev=0;
        while(x>rev){
            rev = (10*rev) + (x % 10);
            x /= 10;
        }

        if(rev == x) return true;
        if(rev / 10 == x) return true;

        return false;
    }
}
