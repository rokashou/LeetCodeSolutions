/*
Uploaded: 11/23/2021 23:16

Runtime: 107 ms, faster than 27.55% of C# online submissions for Integer to Roman.
Memory Usage: 36.6 MB, less than 54.17% of C# online submissions for Integer to Roman.
*/

public class Solution {
    public string IntToRoman(int num) {
        string result = string.Empty;

        int thousand = num / 1000;
        for(int i=0;i<thousand; i++){
            result += 'M';
        }

        int hundred = (num % 1000)/100;
        switch(hundred){
            case 9: result += "CM"; break;
            case 8: result += "DCCC"; break;
            case 7: result += "DCC"; break;
            case 6: result += "DC"; break;
            case 5: result += "D"; break;
            case 4: result += "CD"; break;
            case 3: result += "CCC"; break;
            case 2: result += "CC"; break;
            case 1: result += "C"; break;
        }

        int doze = (num % 100) / 10;
        switch(doze){
            case 9: result += "XC"; break;
            case 8: result += "LXXX"; break;
            case 7: result += "LXX"; break;
            case 6: result += "LX"; break;
            case 5: result += "L"; break;
            case 4: result += "XL"; break;
            case 3: result += "XXX"; break;
            case 2: result += "XX"; break;
            case 1: result+= "X"; break;
        }

        int de = num % 10;
        switch(de){
            case 9: result+="IX"; break;
            case 8: result+="VIII"; break;
            case 7: result+="VII"; break;
            case 6: result+="VI"; break;
            case 5: result+="V"; break;
            case 4: result+="IV"; break;
            case 3: result+="III"; break;
            case 2: result+="II"; break;
            case 1: result+="I"; break;
        }

        return result;
    }
}
