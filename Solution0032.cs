/*
Runtime: 77 ms, faster than 70.05% of C# online submissions for Longest Valid Parentheses.
Memory Usage: 35.8 MB, less than 74.76% of C# online submissions for Longest Valid Parentheses.
Uploaded: 05/24/2022 19:55
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        int cnt = 0, len = 0, res=0; 
        foreach(var ch in s){
            if(ch == '(') cnt ++;
            else cnt --;  
            if(cnt <0) {
               cnt = 0;   //) exists more than (
               len = 0;    
            }  else {
                len ++ ; 
                
                if(cnt == 0) res = Math.Max(res, len);
            }
        }
        
        cnt =0;
        len =0; 
        for(int i=s.Length -1; i>=0; i--){
           if(s[i] == ')') 
               cnt++;             
           else 
               cnt --; 
            
           if(cnt <0){ 
               cnt =0;
               len =0;
           } else {
               len ++; 
               if(cnt == 0) res = Math.Max(res, len);
           }
        }
        
        return res; 
    }
}





/*
Runtime: 126 ms, faster than 21.70% of C# online submissions for Longest Valid Parentheses.
Memory Usage: 35.7 MB, less than 82.78% of C# online submissions for Longest Valid Parentheses.
Uploaded: 05/24/2022 19:52	
*/

public class Solution {
    public int LongestValidParentheses(string s) {
        int maxans = 0;
        Stack<int> table = new Stack<int>();
        table.Push(-1);

        for(int i = 0;i<s.Length;i++)
        {
            switch (s[i])
            {
                case '(':
                    table.Push(i);
                    break;
                case ')':
                    table.Pop();
                    if (table.Count == 0)
                        table.Push(i);
                    else
                        maxans = Math.Max(maxans, i-table.Peek());
                    break;
            }
        }

        return maxans;
    }
}
