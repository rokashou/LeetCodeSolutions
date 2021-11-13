public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // Official Solution Approach 1: With MonotonicStack
        /*
        Uploaded: 11/13/2021 19:47
        Runtime: 316 ms, faster than 72.50% of C# online submissions for Daily Temperatures.
        Memory Usage: 50.2 MB, less than 19.38% of C# online submissions for Daily Temperatures.
        */
        int[] answer = new int[temperatures.Length];
        int n = temperatures.Length;
        Stack<int> stack = new Stack<int>();

        for(int currDay = 0; currDay < n; currDay++){
            int currentTemp = temperatures[currDay];
            // Pop until the current day's temperature is not 
            // warmer than the temperature at the top of the stack
            while(stack.Count > 0 && temperatures[stack.Peek()] < currentTemp) {
                    int prevDay = stack.Pop();
                    answer[prevDay] = currDay - prevDay;
            }
            stack.Push(currDay);
        }

        return answer;
    }
}
