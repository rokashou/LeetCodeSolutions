/*
Runtime 312 ms, Beats 78.20%
Memory 56.8 MB, Beats 54.13%
Feb 12, 2023 19:12

*/

public class OrderedStream {
    private string[] StreamTable;
    private int _currChunkLeadIndex;

    public OrderedStream(int n)
    {
        StreamTable = new string[n];
        Array.Fill(StreamTable,"");
        _currChunkLeadIndex = 0;
    }

    public IList<string> Insert(int idKey, string value)
    {
        // insert the value into the stream
        StreamTable[idKey-1] = value;

        List<string> result = new List<string>();

        while(_currChunkLeadIndex<StreamTable.Length && !string.IsNullOrEmpty(StreamTable[_currChunkLeadIndex]))
        {
            result.Add(StreamTable[_currChunkLeadIndex]);
            _currChunkLeadIndex++;
        }

        return result;
    }
}
