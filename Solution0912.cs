/*
Runtime 274 ms, Beats 91.43%
Memory 63.5 MB, Beats 5.71%
Mar 01, 2023 23:56
*/

public class Solution {
    // Merges two subarrays of arr[].
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temp arrays
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        // Copy data to temp arrays
        Array.Copy(arr, l, L, 0, n1);
        Array.Copy(arr, m+1, R, 0, n2);

        // Merge the temp arrays

        // Initial indexes of first and second subarrays
        i = 0;j = 0;

        // Initial index of merged subarray array
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of L[] if any
        while (i < n1)
        {
            arr[k] = L[i];
            i++; k++;
        }

        // Copy remaining elements of R[] if any
        while (j < n2)
        {
            arr[k] = R[j];
            j++; k++;
        }
    }

    // Main function that sorts arr[l..r] using merge()
    void sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            // Find the middle point
            int m = l + (r - l) / 2;

            // Sort first and second halves
            sort(arr, l, m);
            sort(arr, m + 1, r);

            // Merge the sorted halves
            merge(arr, l, m, r);
        }
    }
            

    public int[] SortArray(int[] nums)
    {
        // Merge Sort
        sort(nums, 0, nums.Length - 1);
        return nums;
    }
}
