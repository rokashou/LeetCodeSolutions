/*
Apr 20, 2023 23:52
Runtime 97 ms Beats 76.14%
Memory 40.1 MB Beats 95.67%
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length-1;
        int n = matrix[0].Length - 1;
        if (matrix[0][0] > target || matrix[m][n] < target)
            return false;

        // find the row
        int row = SearchRow(matrix, target);

        // find in row
        return SearchInRow(matrix[row],target);

    }

    private int SearchRow(int[][] matrix, int target)
    {
        int btm = 0, top = matrix.Length - 1;
        int n = matrix[0].Length - 1;
        while(btm < top)
        {
            int mid = btm + (top - btm) / 2;
            if (matrix[mid][0] <= target && matrix[mid][n] >= target)
                return mid;
            if (matrix[mid][0] > target)
                top = mid - 1;
            if (matrix[mid][n] < target)
                btm = mid + 1;
        }
        return btm;
    }

    private bool SearchInRow(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == target) return true;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
