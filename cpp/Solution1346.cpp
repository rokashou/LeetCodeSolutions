/*
1346. Check If N and Its Double Exist

Dec 01, 2024 23:58
Runtime 0ms, Beats 100.00%
Memory 13.84MB, Beats 15.78%
*/


class Solution {
public:
    bool checkIfExist(vector<int>& arr) {
        unordered_set<int> hashtable;
        for (auto v : arr) {
            if (hashtable.contains(v * 2)) return true;
            if (v % 2 == 0 && hashtable.contains(v / 2)) return true;
            hashtable.insert(v);
        }
        return false;
    }
};
