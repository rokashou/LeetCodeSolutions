/*
Runtime: 157 ms, faster than 44.00% of C# online submissions for Remove All Adjacent Duplicates in String II.
Memory Usage: 41.5 MB, less than 53.60% of C# online submissions for Remove All Adjacent Duplicates in String II.
Uploaded: 05/06/2022 22:56
*/

public class Solution {
    public string RemoveDuplicates(string s, int k)
    {
        List<char> resultList = new List<char>();
        List<int> countList = new List<int>();

        for(int i = 0; i < s.Length; i++)
        {
            if (resultList.Count != 0 &&
                resultList[resultList.Count - 1] == s[i])
            {
                countList[resultList.Count - 1] += 1;
                if (countList[resultList.Count - 1] == k)
                {
                    countList.RemoveAt(resultList.Count - 1);
                    resultList.RemoveAt(resultList.Count - 1);
                }
                continue;
            }
            else
            { 
                resultList.Add(s[i]);
                countList.Add(1);
            }
        }

        return RepeatChars(resultList,countList);
    }

    private string RepeatChars(List<char> charList, List<int> countList)
    {
        string result = string.Empty;
        for(int i = 0; i< charList.Count; i++)
        {
            result += new string(charList[i], countList[i]);
        }
        return result;
    }
}

