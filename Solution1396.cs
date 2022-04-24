/*
Runtime: 719 ms, faster than 5.13% of C# online submissions for Design Underground System.
Memory Usage: 57.7 MB, less than 85.90% of C# online submissions for Design Underground System.
Uploaded: 04/25/2022 01:23
*/

public class UndergroundSystem {
    private Dictionary<int, int> CheckedCustomer;
    private Dictionary<int, string> CustomerEntryStation;
    private Dictionary<string,double> StationTotalTime; // startStation, endStation, TotalTime
    private Dictionary<string,int> StationCustomerCount;

    private void AddTotalTime(string stationName,int time)
    {
        if (!StationTotalTime.ContainsKey(stationName)) { 
            StationTotalTime.Add(stationName, 0);
            StationCustomerCount.Add(stationName, 0);
        }
        StationTotalTime[stationName] += time;
        StationCustomerCount[stationName] += 1;
    }

    public UndergroundSystem()
    {
        CheckedCustomer = new Dictionary<int, int>();
        CustomerEntryStation = new Dictionary<int, string>();
        StationTotalTime = new Dictionary<string, double>();
        StationCustomerCount = new Dictionary<string, int>();
    }       

    public void CheckIn(int id, string stationName, int t)
    {
        CheckedCustomer.Add(id, t);
        CustomerEntryStation.Add(id, stationName);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        int time = t - CheckedCustomer[id];
        string fullname = CustomerEntryStation[id] +","+ stationName;
        CheckedCustomer.Remove(id);
        CustomerEntryStation.Remove(id);

        AddTotalTime(fullname, time);
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        string fullname = startStation + "," + endStation;
        return StationTotalTime[fullname] / StationCustomerCount[fullname];
    }

}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */
 
