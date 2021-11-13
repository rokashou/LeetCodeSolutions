public class Solution {
    public int[] DailyTemperatures_BF(int[] temperatures) {
        /* TLE */
        int[] answer = new int[temperatures.Length];
        for(int idx1 = 1; idx1<temperatures.Length; idx1++){
            for(int idx2=0;idx2<idx1;idx2++){
                if(answer[idx2]>0) continue;

                if(temperatures[idx2]<temperatures[idx1]){
                    answer[idx2] = idx1 - idx2;
                }
            }
        }
        return answer;
    }
    
    public int[] DailyTemperatures_MonotonicStack(int[] temperatures) {
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

    public int[] DailyTemperatures_OptimizedSpaceArray(int[] temperatures) {
        // Official Solution Approach 2: Array, Optimized Space
        /*
        Uploaded: 11/13/2021 20:08
        Runtime: 292 ms, faster than 95.31% of C# online submissions for Daily Temperatures.
        Memory Usage: 49.1 MB, less than 52.50% of C# online submissions for Daily Temperatures.
        */
        int[] answer = new int[temperatures.Length];
        int n = temperatures.Length;
        int hottest = 0;

        for(int currDay = n-1; currDay >= 0; currDay--){
            int currentTemp = temperatures[currDay];
            if(hottest <= currentTemp) {
                hottest = currentTemp;
                continue;
            }

            int days = 1;
            while(temperatures[currDay + days] <= temperatures[currDay]){
                // Use information from answer to search for the next warmer day
                days += answer[currDay + days];
            }
            answer[currDay] = days;
        }

        return answer;
    }

}
