/*
Uploaded: 12/25/2021 00:32	
Runtime: 84 ms, faster than 44.89% of C# online submissions for Roman to Integer.
Memory Usage: 39.5 MB, less than 38.63% of C# online submissions for Roman to Integer.
*/

public class Solution {
    public int RomanToInt(string s) {
        int result=0;
        for(int i=0;i<s.Length;i++){
            switch(s[i]){
                case 'I':
                    if(i<s.Length-1) {
                        if(s[i+1]=='V') {
                            result+=4;
                            i+=1;
                            break;
                        }
                        if(s[i+1]=='X') {
                            result+=9;
                            i+=1;
                            break;
                        }
                    }
                    result+=1;
                    break;
                case 'V':
                    result+=5;
                    break;
                case 'X':
                    if(i<s.Length-1) {
                        if(s[i+1]=='L'){
                            result+=40;
                            i+=1;
                            break;
                        }
                        if(s[i+1]=='C'){
                            result+=90;
                            i+=1;
                            break;
                        }
                    }
                    result+=10;
                    break;
                case 'L':
                    result+=50;
                    break;
                case 'C':
                    if(i<s.Length-1){
                        if(s[i+1]=='D'){
                            result+=400;
                            i+=1;
                            break;
                        }
                        if(s[i+1]=='M'){
                            result+=900;
                            i+=1;
                            break;
                        }

                    }
                    result+=100;
                    break;
                case 'D':
                    result+=500;
                    break;
                case 'M':
                    result+=1000;
                    break;

            }
        }
        return result;
    }
}
