/*
Runtime: 64 ms, faster than 98.03% of C# online submissions for Valid Parentheses.
Memory Usage: 38 MB, less than 18.17% of C# online submissions for Valid Parentheses.
Uploaded: 03/24/2022 23:10
*/


public class Solution {
    public bool IsValid(string s)
    {
        Stack<int> st = new Stack<int>();
        foreach(char ch in s){
            int t = tol(ch);
            if(t <= 3){
                st.Push(t);
            }else{
                if(st.Count == 0) return false;

                int p = st.Peek();
                if(t+p == 7)
                    st.Pop();
                else
                    return false;
            }
        }
        return st.Count == 0;
    }

    int tol(char input)
    {
        switch (input)
        {
            case '(':
                return 1;
            case '{':
                return 2;
            case '[':
                return 3;
            case ']':
                return 4;
            case '}':
                return 5;
            case ')':
                return 6;
            default:
                return 0;
        }
    }
}

