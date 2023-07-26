/*
Jul 27, 2023 01:40
Runtime 275 ms Beats 100%
Memory 52.9 MB Beats 13.33%
*/

public class Solution {
    double timeRequired(int[] dist, int speed) {
        double time = 0.0d;
        for(int i = 0; i < dist.Length; i++) {
            double t = (double)dist[i] / (double)speed;
            // round off to the next integer, if not the last ride.
            time += (i == dist.Length - 1) ? t : Math.Ceiling(t);
        }
        return time;
    }

    public int MinSpeedOnTime(int[] dist, double hour)
    {
        int left = 1;
        int right = 10_000_000;
        int minSpeed = -1;
        while(left <= right) {
            int mid = left + (right - left) / 2;

            // move to hte left half
            if (timeRequired(dist, mid) <= hour) {
                minSpeed = mid;
                right = mid - 1;
            }
            else {
                // move to the right half
                left = mid + 1;
            }
        }
        return minSpeed;
    }
}
