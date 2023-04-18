/*
Apr 18, 2023 19:03
Runtime 71 ms Beats 92.80%
Memory 41.2 MB Beats 92%
*/

public class Solution {
    public bool IsNumber(string s) {
        /* status : 
           1 = sign
           2 = lead digit
           3 = lead dot with digit
           4 = follow digit after dot
           5 = dot withnot lead digit
          10 = e
          12 = e sign
          11 = e lead digit */
        int status = 0;
        bool flag = false;

        foreach(var c in s)
        {
            switch (c)
            {
                case '+':
                case '-':
                    if (status == 0)
                        status = 1;
                    else if (status == 10)
                        status = 12;
                    else
                        status = -1;
                    break;
                case '0': case '1': case '2': case '3': case '4':
                case '5': case '6': case '7': case '8': case '9':
                    if (status == 0 || status == 1) status = 2;
                    if (status == 3) status = 4;
                    if (status == 5) status = 4;
                    if (status == 10 || status == 12) status = 11;

                    if (status == 2 || status == 4 || status == 11)
                        flag = true;
                    else
                        status = -1;
                    break;
                case '.':
                    if (status == 0 || status == 1)
                        status = 5;
                    else if (status == 2)
                        status = 3;
                    else
                        status = -1;
                    break;
                case 'e':
                case 'E':
                    if (status == 2 || status == 3 || status == 4)
                        status = 10;
                    else
                        status = -1;
                    break;
                default:
                    status = -1;
                    break;
            }
        }

        if (status == 3 && s.Length == 1) return false;

        if (status == 2 || status == 3 || status == 4 || status == 11)
            return true;
        else
            return false;
        
    }
}
