
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


#region Heap Sort
/*
Runtime 248 ms, Beats 58.16%
Memory 57.6 MB, Beats 42.86%
Accepted: Jan 25, 2023 17:23
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

    private static int CompareMatrixRowByKth(int[] row1, int[] row2, int k)
    {
        return row2[k] - row1[k];
    }


    private static void HeapSortByKth(int[][] matrix, int k)
    {
        int heapSize = matrix.Length;
        buildMaxHeapByKth(matrix,k);

        for(int i = heapSize - 1; i >= 1; i--)
        {
            SwapMatrixRow(matrix, i, 0);
            heapSize--;
            SinkByKth(matrix, heapSize, 0, k);
        }
    }

    private static void buildMaxHeapByKth(int[][] matrix,int k)
    {
        int heapSize = matrix.Length;
        for (int i = (heapSize / 2) - 1; i >= 0; i--)
            SinkByKth(matrix, heapSize, i, k);
    }

    private static void SinkByKth(int[][] matrix, int heapSize, int toSinkPos, int k)
    {
        int leftPos = GetLeftKidPos(toSinkPos);
        int rightPos = GetRightKidPos(toSinkPos);

        if(leftPos >= heapSize)
        {
            // No left kid => no kid at all
            return;
        }

        int larestKidPos;
        bool leftIsLargest;

        if(rightPos >= heapSize || CompareMatrixRowByKth(matrix[rightPos],matrix[leftPos],k) < 0)
        {
            larestKidPos = leftPos;
            leftIsLargest = true;
        }
        else
        {
            larestKidPos = rightPos;
            leftIsLargest = false;
        }

        if(CompareMatrixRowByKth(matrix[larestKidPos],matrix[toSinkPos],k) > 0)
        {
            SwapMatrixRow(matrix, toSinkPos, larestKidPos);

            if (leftIsLargest)
                SinkByKth(matrix, heapSize, GetLeftKidPos(toSinkPos),k);
            else
                SinkByKth(matrix, heapSize, GetRightKidPos(toSinkPos),k);
        }

    }

    private static int GetLeftKidPos(int parentPos)
    {
        return (2 * (parentPos + 1)) - 1;
    }

    private static int GetRightKidPos(int parentPos)
    {
        return (2 * (parentPos + 1));
    }

    public int[][] SortTheStudents(int[][] score, int k)
    {
        HeapSortByKth(score, k);
        return score;
    }
    
}
#endregion // HeapSort
