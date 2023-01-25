
#region QuickSort
/*
Runtime 239 ms, Beats 70.41%
Memory 57.7 MB, Beats 37.76%
Accepted: Jan 25, 2023 16:56
*/
public class Solution {
    private static void SwapMatrixRow(int[][] matrix, int row1, int row2)
    {
        int n = matrix[row1].Length;
        int[] temp = new int[n];
        Array.Copy(matrix[row1], temp, n);
        Array.Copy(matrix[row2], matrix[row1], n);
        Array.Copy(temp, matrix[row2], n);
    }

    private static int CompareMatrixRow(int[] row1, int[] row2, int k)
    {
        return row1[k] - row2[k];
    }

    private static void QuickSortByKth(int[][] matrix, int left, int right, int k)
    {
        if(left < right)
        {
            int pivot = PartitionByKth(matrix, left, right, k);
            if(pivot > 1)
            {
                QuickSortByKth(matrix, left, pivot - 1,k);
            }
            if(pivot + 1 < right)
            {
                QuickSortByKth(matrix, pivot + 1, right, k);
            }
        }
    }

    private static int PartitionByKth(int[][] matrix, int left, int right, int k)
    {
        int pivot = matrix[left][k];
        while (true)
        {
            while (matrix[left][k] > pivot) left++;

            while (matrix[right][k] < pivot) right--;

            if(left < right)
            {
                if (matrix[left][k] == matrix[right][k]) return right;

                SwapMatrixRow(matrix, left, right);
            }
            else
            {
                return right;
            }
        }
    }

    public int[][] SortTheStudents(int[][] score, int k)
    {
        QuickSortByKth(score, 0, score.Length - 1, k);
        return score;
    }
    
}

#endregion // QuickSort

