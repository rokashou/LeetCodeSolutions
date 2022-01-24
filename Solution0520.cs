/*
Uploaded: 01/24/2022 22:24
Runtime: 176 ms, faster than 5.32% of C# online submissions for Detect Capital.
Memory Usage: 36.2 MB, less than 100.00% of C# online submissions for Detect Capital.
*/


public class Solution {
    private int status = 0;

    private void NextStatus(char ch){
        switch(status){
            case -1:
                break;
            case 0: // no read
                if(char.IsUpper(ch)){
                    status = 1;
                    break;
                }
                if(char.IsLower(ch)){
                    status = 2;
                }
                break;
            case 1: // read 1 upper
                if(char.IsUpper(ch)){
                    status = 3; // 2 or more upper
                    break;
                }
                if(char.IsLower(ch)){
                    status = 2;
                }
                break;
            case 2: // read any lower
                if(char.IsUpper(ch)){
                    status = -1;
                }
                break;
            case 3: // 2 upper: only more upper is acceptable;
                if(char.IsLower(ch)){
                    status = -1;
                }
                break;
        }
    }

    public bool DetectCapitalUse(string word)
    {
        status = 0;
        foreach(var ch in word){
            NextStatus(ch);
            if(status == -1){
                return false;
            }
        }
        return true;
    }
}
