/*
Runtime: 127 ms, faster than 68.25% of C# online submissions for Validate Stack Sequences.
Memory Usage: 40.3 MB, less than 68.25% of C# online submissions for Validate Stack Sequences.
Uploaded: 03/16/2022 21:31	
*/


public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        int N = pushed.Length;
        Stack<int> stack = new Stack<int>();

        int j = 0;
        foreach(int x in pushed){
            stack.Push(x);
            while(stack.Count > 0 && j<N && stack.Peek() == popped[j]){
                stack.Pop();
                j++;
            }
        }

        return j == N;
    }
}
