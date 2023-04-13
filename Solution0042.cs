/*
Apr 13, 2023 23:10
Runtime 97 ms Beats 72.94%
Memory 42.9 MB Beats 17.2%
*/

public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int result = 0;
        int[]  leftTop = new int[height.Length];
        int[]  rightTop = new int[height.Length];
       

        for(int i=0; i<n;i++)
        {
            if(i==0)
                leftTop[i]=0;
            else
                leftTop[i]= Math.Max(leftTop[i-1], height[i-1]);
        }

        for(int i=n-1; i>=0;i--)
        {
            if(i==n-1)
                rightTop[i]=0;
            else
                rightTop[i]= Math.Max(rightTop[i+1], height[i+1]);
        }


        for(int i=0;i<height.Length;i++)        
        {
            int newValue = Math.Min(leftTop[i],rightTop[i]);
            //Console.Write(" newValue = " + newValue);
            if(height[i]<newValue)
            {                    
                result = result + (newValue - height[i]) ;           
                //Console.Write(" adding = " + (newValue -height[i]));
            }
            //Console.WriteLine("");
        }

        return result;
    }
}


/*
Apr 13, 2023 23:07
Runtime 111 ms Beats 21.6%
Memory 42.4 MB Beats 67.78%
2 pointer
*/

public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length - 1;
        int ans = 0;
        int left_max = 0, right_max = 0;
        while(left < right)
        {
            if (height[left] < height[right])
            {
                if(height[left] >= left_max)
                    left_max = height[left];
                else
                    ans += (left_max - height[left]);
                left++;
            }
            else
            {
                if (height[right] >= right_max)
                    right_max = height[right];
                else
                    ans += (right_max - height[right]);
                right--;
            }
        }
        return ans;
    }
}
