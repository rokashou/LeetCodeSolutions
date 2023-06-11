/*
Jun 11, 2023 15:59
Runtime 641 ms Beats 97.37%
Memory 100.9 MB Beats 94.74%
*/


public class SnapshotArray {
    private int _snapId;
    private Dictionary<int, List<(int id, int value)>> _history;

    public SnapshotArray(int length) {
        _history = new Dictionary<int, List<(int id, int value)>>();

        for (int i = 0; i < length; i++){
            _history[i] = new List<(int id, int value)>();
            _history[i].Add((0, 0));
        }
    }
    
    public void Set(int index, int val) {
        _history[index].Add((_snapId, val));
    }
    
    public int Snap() {
        return _snapId++;
    }
    
    public int Get(int index, int snap_id) {
        int left = 0;
        int right = _history[index].Count - 1;

        while (left <= right){
            int mid = left + (right - left) / 2;

            if (_history[index][mid].id <= snap_id){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return _history[index][right].value;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */
 
