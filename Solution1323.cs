/*
Runtime: 30 ms, faster than 81.32% of C# online submissions for Maximum 69 Number.
Memory Usage: 25.1 MB, less than 84.71% of C# online submissions for Maximum 69 Number.
*/

public class Solution {
    public int Maximum69Number (int num) {
        var array = num.ToString().ToCharArray();
        
        for(int idx = 0; idx < array.Length; idx++)
        {
            if (array[idx] == '6')
            {
                array[idx] = '9';
                break;
            }
        }

        var result = int.Parse(new string(array));
        return result;
    }
}
