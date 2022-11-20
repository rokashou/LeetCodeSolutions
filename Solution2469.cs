/*
Runtime: 183 ms, faster than 9.71% of C# online submissions for Convert the Temperature.
Memory Usage: 34.9 MB, less than 45.43% of C# online submissions for Convert the Temperature.
Uploaded: 11/20/2022 22:41
*/


public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 1.80 + 32.0;

        return new double[] { kelvin, fahrenheit };
    }
}
