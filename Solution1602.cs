/*
Runtime: 349 ms, faster than 5.45% of C# online submissions for Design Parking System.
Memory Usage: 46 MB, less than 85.90% of C# online submissions for Design Parking System.
Uploaded: 05/28/2022 20:26
*/

public class ParkingSystem {
    private int[] _capacity;

    public ParkingSystem(int big, int medium, int small)
    {
        _capacity = new int[] {big,medium,small};
    }

    public bool AddCar(int carType)
    {
        if (_capacity[carType - 1] > 0)
        {
            _capacity[carType - 1] -= 1;
            return true;
        }
        else
            return false;
    }
}
