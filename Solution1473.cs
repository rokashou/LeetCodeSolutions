public class Solution {
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        // Maximum cost possible plus 1
        const int MAX_COST = 1000001;

        int[,] prevMemo = new int[target + 1, n];

        // Initialize prevMemo array
        for (int i = 0; i <= target; i++)
            for (int j = 0; j < n; j++)
                prevMemo[i, j] = MAX_COST;

        // Initaialize for house 0, neighborhood will be 1
        for(int color = 1; color <= n; color++)
        {
            if(houses[0] == color)
            {
                // If the house has same color, no cost
                prevMemo[1, color - 1] = 0;
            }else if (houses[0] == 0)
            {
                // If the house is not painted, assign the corresponding cost
                prevMemo[1, color - 1] = cost[0][color - 1];
            }
        }

        for(int house = 1; house < m; house++)
        {
            int[,] memo = new int[target + 1, n];

            // Initialize memo array
            for (int i = 0; i <= target; i++)
                for (int j = 0; j < n; j++)
                    memo[i, j] = MAX_COST;

            for(int neighborhoods = 1;neighborhoods <= Math.Min(target, house + 1); neighborhoods++)
            {
                for(int color =1;color <= n; color++)
                {
                    // If the house is already painted, and color is different
                    if(houses[house] != 0 && color != houses[house])
                    {
                        // Cannot be painted with different color
                        continue;
                    }

                    int currCost = MAX_COST;
                    // Iterate over all the possible color for previous house
                    for(int prevColor = 1; prevColor <= n; prevColor++)
                    {
                        if(prevColor != color)
                        {
                            // Decrement the neighborhood as adjacent houses has different color
                            currCost = Math.Min(currCost, prevMemo[neighborhoods - 1, prevColor - 1]);
                        }
                        else
                        {
                            // Previous house has the same color, no change in neighborhood count
                            currCost = Math.Min(currCost, prevMemo[neighborhoods, color - 1]);
                        }
                    }

                    // If the house is already painted cost to paint is 0
                    int costToPaint = houses[house] != 0 ? 0 : cost[house][color - 1];
                    memo[neighborhoods, color - 1] = currCost + costToPaint;
                }
            }
            // Update the table to have the current house results
            prevMemo = memo;
        }

        int minCost = MAX_COST;
        // Find the minimum cost with m houses and target neighborhoods
        // By comparing cost for different color for the lat house
        for(int color = 1; color <= n; color++)
        {
            minCost = Math.Min(minCost, prevMemo[target, color - 1]);
        }

        // Return -1 if the answer is MAX_COST as it implies no answer possible
        return minCost == MAX_COST ? -1 : minCost;
            
    }
}
