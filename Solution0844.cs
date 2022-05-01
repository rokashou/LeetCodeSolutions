/*
Runtime: 108 ms, faster than 32.41% of C# online submissions for Backspace String Compare.
Memory Usage: 37.7 MB, less than 28.73% of C# online submissions for Backspace String Compare.
Uploaded: 05/01/2022 12:03
*/

// Try with string object
public class Solution {
    private string DecodeBackspaceString(string input)
    {
        string result = "";

        foreach(char c in input)
        {
            switch (c)
            {
                case '#':
                    if (result.Length == 0) break;
                    result=result.Remove(result.Length - 1);
                    break;
                default:
                    result += c;
                    break;
            }
        }

        return result;
    }

    public bool BackspaceCompare(string s, string t)
    {
        return DecodeBackspaceString(s).Equals(DecodeBackspaceString(t));
    }
}


/*
Runtime: 147 ms, faster than 5.22% of C# online submissions for Backspace String Compare.
Memory Usage: 37.1 MB, less than 50.23% of C# online submissions for Backspace String Compare.
Uploaed: 05/01/2022 12:07
*/


// Try wz StringBuilder
public class Solution {
    private string DecodeBackspaceString(string input)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        foreach(char c in input)
        {
            switch (c)
            {
                case '#':
                    if (sb.Length == 0) break;
                    sb=sb.Remove(sb.Length - 1,1);
                    break;
                default:
                    sb.Append(c);
                    break;
            }
        }

        return sb.ToString();
    }

    public bool BackspaceCompare(string s, string t)
    {
        return DecodeBackspaceString(s).Equals(DecodeBackspaceString(t));
    }
}

// with char array
/*
Runtime: 86 ms, faster than 68.82% of C# online submissions for Backspace String Compare.
Memory Usage: 37.3 MB, less than 43.32% of C# online submissions for Backspace String Compare.
Uploaded: 05/01/2022 12:15
*/

public class Solution {
    private const int MaxStringLength = 201;

    private string DecodeBackspaceString(string input)
    {
        char[] result = new char[MaxStringLength];
        int currentIndex = 0;

        foreach(char c in input)
        {
            switch (c)
            {
                case '#':
                    if (currentIndex == 0) break;
                    currentIndex -= 1;
                    break;
                default:
                    result[currentIndex] = c;
                    currentIndex += 1;
                    break;
            }
        }


        return new string(result,0,currentIndex);
    }

    public bool BackspaceCompare(string s, string t)
    {
        return DecodeBackspaceString(s).Equals(DecodeBackspaceString(t));
    }
}


