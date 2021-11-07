/*
Runtime: 171 ms, 54.18%
Memory Usage: 45.3 MB, 70.25%
Uploaded: 10/25/2021 23:28
*/


public class MinStack {
        List<int> stack;
        int min;
        // Initializes the stack object;
        public MinStack()
        {
            //stack = new List<int>();
            stack = new List<int>();
            min = int.MaxValue;
        }

        public void Push(int val)
        {
            if (stack.Count == 0) min = val;
            if (val < min) min = val;
            stack.Add(val);
        }

        public void Pop()
        {
            if (min == stack[stack.Count - 1]) min = int.MaxValue;
            if (stack.Count > 0) {
                stack.RemoveAt(stack.Count - 1);
            }
            
            if(stack.Count > 0 && min == int.MaxValue)
            {
                min = stack.Min();
            }
            
        }

        public int Top()
        {
            return stack[stack.Count - 1];
        }

        public int GetMin()
        {
            return min;
        }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
