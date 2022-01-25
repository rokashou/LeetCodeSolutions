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


public class Solution520_2
{
    /*
    Uploaded: 01/25/2022 07:47
    Runtime: 147 ms, faster than 5.26% of C# online submissions for Detect Capital.
    Memory Usage: 36.4 MB, less than 88.42% of C# online submissions for Detect Capital.
    */
    public bool DetectCapitalUse(string word)
    {
        string tmp = word.ToUpper();
        if(tmp == word) return true;
        tmp = char.ToUpper(word[0]) + word.Substring(1).ToLower();
        if(tmp == word) return true;
        return false;
    }
}

