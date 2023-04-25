/*
Apr 25, 2023 22:08
Runtime 182 ms Beats 44%
Memory 57 MB Beats 80%
*/


public class SmallestInfiniteSet {
    private bool[] _list;
    private const int MAXCOUNT = 1000;

    public SmallestInfiniteSet()
    {
        _list = new bool[MAXCOUNT + 2];
    }

    public int PopSmallest()
    {
        for(int i = 0; i < MAXCOUNT; i++)
        {
            if (!_list[i])
            {
                _list[i] = true;
                return i + 1;
            }
        }
        return MAXCOUNT+1;
    }

    public void AddBack(int num)
    {
        if (_list[num - 1])
            _list[num - 1] = false;
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
