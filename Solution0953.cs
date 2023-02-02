/*
Runtime 103 ms, Beats 59.52%
Memory 40.8 MB, Beats 60.32%
Feb 02, 2023 21:08
*/

public class Solution {
    public bool IsAlienSorted(string[] words, string order)
    {
        for(int i = 0; i < words.Length - 1; i++)
        {
            if (CompareWordsByOrder(words[i], words[i + 1], order) > 0) return false;
        }
        return true;        
    }

    public int CompareWordsByOrder(string word1, string word2, string order)
    {
        int n1 = word1.Length;
        int n2 = word2.Length;
        int i = 0;
        while(i<n1 && i < n2)
        {
            int index1 = order.IndexOf(word1[i]);
            int index2 = order.IndexOf(word2[i]);
            if (index1 != index2) return index1 - index2;
            i++;
        }
        if (i == n1 && n1 == n2)
            return 0;
        if (n1 > n2)
            return word1[i];
        else
            return word2[i] * -1;
    }
}

