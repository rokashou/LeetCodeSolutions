/*
Runtime: 112 ms, faster than 55.24% of C# online submissions for Baseball Game.
Memory Usage: 37.8 MB, less than 89.52% of C# online submissions for Baseball Game.
Uploaded: 04/10/2022 15:12
*/



public class Solution {
    List<int> records;

    public int CalPoints(string[] ops)
    {
        records = new List<int>();
        foreach(string op in ops){
            RunCommand(op);
        }
        return GetSum();
    }

    private void RunCommand(string cmd){
        switch(cmd[0]){
            case '+':
                records.Add(records[records.Count - 1] + records[records.Count - 2]);
                break;
            case 'D':
                records.Add(records[records.Count - 1] * 2);
                break;
            case 'C':
                records.RemoveAt(records.Count - 1);
                break;
            default:
                records.Add(int.Parse(cmd));
                break;
        }
    }

    private int GetSum(){
        int result = 0;
        foreach(int n in records) result += n;
        return result;
    }
}
