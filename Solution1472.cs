/*
Mar 18, 2023 11:59
Runtime 293 ms, Beats 86.14%
Memory 62.8 MB, Beats 23.76%
*/


public class BrowserHistory {

    private List<string> historyUrl;
    private int currentHistoryIndex;

    // Initializes the object with the homepage of the browser
    public BrowserHistory(string homepage)
    {
        historyUrl = new List<string>();
        historyUrl.Add(homepage);
        currentHistoryIndex = 0;
    }

    // Visits url from the current page.
    // It clears up all the forward history.
    public void Visit(string url)
    {
        if(currentHistoryIndex < historyUrl.Count - 1)
            historyUrl.RemoveRange(currentHistoryIndex + 1, historyUrl.Count - currentHistoryIndex - 1);
        historyUrl.Add(url);
        currentHistoryIndex += 1;
    }

    // Move steps back in history. If you can only return x steps in the history and steps > x,
    // you will return only x steps. Return the current url after moving back in history at most steps.
    public string Back(int steps)
    {
        currentHistoryIndex -= steps;
        if (currentHistoryIndex < 0)
            currentHistoryIndex = 0;
        return historyUrl[currentHistoryIndex];
    }

    // Move steps forward in history.
    // If you can only forward x steps in the history and steps > x, you will forward only x steps.
    // Return the current url after forwarding in history at most steps.
    public string Forward(int steps)
    {
        currentHistoryIndex += steps;
        if (currentHistoryIndex >= historyUrl.Count)
            currentHistoryIndex = historyUrl.Count - 1;
        return historyUrl[currentHistoryIndex];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */
 
