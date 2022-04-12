/*
Second Try
Runtime: 168 ms, faster than 94.47% of C# online submissions for Container With Most Water.
Memory Usage: 47.7 MB, less than 13.16% of C# online submissions for Container With Most Water.
Uploaded: 04/12/2022 23:42
*/
public class Solution {
    public int MaxArea(int[] height)
    {
        int lp = 0;
        int rp = height.Length - 1;
        int result = 0;

        while (lp < rp)
        {
            result = Math.Max(result,
                Math.Min(height[lp],height[rp]) * (rp-lp)
                );


            if(Math.Min(height[lp],height[rp]) == height[lp]) {
                lp++;
            } else {
                rp--;
            }
        }

        return result;
    }
}







/*
Runtime: 270 ms, faster than 41.14% of C# online submissions for Container With Most Water.
Memory Usage: 45 MB, less than 79.27% of C# online submissions for Container With Most Water.
Uploaded: 04/12/2022 23:34
*/




public class Solution {
    public int MaxArea(int[] height)
    {
        int lp = 0;
        int rp = height.Length - 1;
        int result = 0;

        while (lp < rp)
        {
            result = Math.Max(result, CalculateArea(lp, rp, height[lp], height[rp]));

            bool conti = false;
            // left is shorter
            if(height[lp] < height[rp]){
                // find the next longer line for left
                for (int i = lp + 1; i < rp;i++){
                    if(height[i] > height[lp]){
                        lp = i;
                        conti = true;
                        break;
                    }
                }
                if(conti) 
                    continue;
                else
                    break;

            }
            else
            {
                // find the next longer line for right
                for (int i = rp - 1; i > lp;i--){
                    if(height[i]>height[rp]){
                        rp = i;
                        conti = true;
                        break;
                    }
                }
                if(conti)
                    continue;
                else
                    break;
            }

        }

        return result;
    }

    private int CalculateArea(int i, int j, int hi, int hj){
        int height = Math.Min(hi, hj);
        int width = j - i;
        return height * width;
    }
}
