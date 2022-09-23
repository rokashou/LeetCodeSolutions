/*
Runtime: 144 ms, faster than 21.37% of C# online submissions for Goal Parser Interpretation.
Memory Usage: 35.7 MB, less than 51.15% of C# online submissions for Goal Parser Interpretation.
Uploaded: 09/23/2022 23:25
*/

public class Solution {
    public string Interpret(string command) {
        string result = string.Empty;

        int i = 0;
        while (i < command.Length)
        {
            switch (command[i])
            {
                case 'G':
                    result += "G";
                    i += 1;
                    break;
                case '(':
                    if (command[i + 1] == ')') { 
                        result += "o";
                        i += 2;
                    }
                    else
                    {
                        result += "al";
                        i += 4;
                    }
                    break;
            }
        }
        return result;
    }
}
