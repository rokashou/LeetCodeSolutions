/*
Jun 07, 2023 21:28
Runtime 20 ms Beats 83.33%
Memory 27.2 MB Beats 13.89%
*/

public class Solution {
    public int MinFlips(int a, int b, int c) {
        var cS = Convert.ToString(c, 2);
        var bS = Convert.ToString(b, 2);
        var aS = Convert.ToString(a, 2);
        int maxL = Math.Max(cS.Length, bS.Length);
        maxL = Math.Max(maxL, aS.Length);
        cS = cS.PadLeft(maxL, '0');
        bS = bS.PadLeft(maxL, '0');
        aS = aS.PadLeft(maxL, '0');
        Console.WriteLine(aS + " " + bS + " " + cS);
        int res = 0;
        for(int i = maxL-1; i >= 0; i--){
            if(cS[i] == '0'){
                if(aS[i] == '1') res++;
                if(bS[i] == '1') res++;
            }else{
                if(!(aS[i] == '1' || bS[i] == '1')) res++;
            }
        }
        return res;
    }
}


/*
Jun 07, 2023 21:27
Runtime 33 ms Beats 11.11%
Memory 26.5 MB Beats 97.22%
*/

public class Solution {
    public int MinFlips(int a, int b, int c) {
        int flips = 0;
        int careMask = (a | b) ^ c;
        int shift = 0;
        while (careMask != 0) {
            int careBit = careMask & 1;
            if (careBit == 1) {
                if (shift > 0) {
                    a >>= shift;
                    b >>= shift;
                    c >>= shift;
                }
                var aBit = a & 1;
                var bBit = b & 1;
                var cBit = c & 1;
                if ((aBit | bBit) != cBit)
                    flips += cBit == 0 && (aBit ^ bBit) == 0 ? 2 : 1;
                shift = 1;
            }
            else
                shift++;
            careMask >>= 1;
        }
        return flips;
    }
}
