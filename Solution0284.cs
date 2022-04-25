/*
Runtime: 154 ms, faster than 57.14% of C# online submissions for Peeking Iterator.
Memory Usage: 40.1 MB, less than 92.86% of C# online submissions for Peeking Iterator.
Uploaded: 04/25/2022 23:18
*/



// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    Queue<int> table = new Queue<int>();

    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator)
    {
        table.Enqueue(iterator.Current);
        while (iterator.MoveNext()) table.Enqueue(iterator.Current);
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return table.Peek();
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        return table.Dequeue();
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return table.Count > 0;
    }
}



// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator_best{
    private IEnumerator<int> _iter;
    private bool _hasNext;

    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator)
    {
        _iter = iterator;
        _hasNext = true;
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return _iter.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        var v = _iter.Current;
        _hasNext = _iter.MoveNext();
        return v;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return _hasNext;
    }
}
