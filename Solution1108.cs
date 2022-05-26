/*
Runtime: 70 ms, faster than 96.82% of C# online submissions for Defanging an IP Address.
Memory Usage: 36.8 MB, less than 16.18% of C# online submissions for Defanging an IP Address.
Uploaded: 05/26/2022 22:50
*/

public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".", "[.]");
    }
}
