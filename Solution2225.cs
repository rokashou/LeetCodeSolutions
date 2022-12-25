/*
  Runtime: 681ms, Beats 92.34%
  Memory: 86.9MB, Beats 5.4%
  
  Uploaded: Dec 25, 2022 23:06
*/


public class Solution {
    class Pair {
        public int id;
        int nWin;
        int nLose;
        public Pair(int id, int nWin, int nLose)
        {
            this.id = id;
            this.nWin = nWin;
            this.nLose = nLose;
        }
        public void AddWin()
        {
            nWin++;
        }
        public void AddLoss()
        {
            nLose++;
        }
        public int getLoss()
        {
            return nLose;
        }
    }


    public IList<IList<int>> FindWinners(int[][] matches)
    {
        IList<IList<int>> result = new List<IList<int>>();

        var map = new Dictionary<int, Pair>();

        for(int i = 0; i < matches.Length; i++)
        {
            int winner = matches[i][0];
            int losser = matches[i][1];
            var winnerObj = map.GetValueOrDefault(winner, new Pair(winner, 0, 0));
            winnerObj.AddWin();
            map[winner] = winnerObj;
            var loserObj = map.GetValueOrDefault(losser, new Pair(losser, 0, 0));
            loserObj.AddLoss();
            map[losser] = loserObj;
        }

        var onlyWin = new List<int>();
        var onlyOneLoss = new List<int>();

        foreach(var entry in map)
        {
            var p = entry.Value;
            if (p.getLoss() == 0) onlyWin.Add(p.id);
            if (p.getLoss() == 1) onlyOneLoss.Add(p.id);
        }

        onlyOneLoss.Sort();
        onlyWin.Sort();
        result.Add(onlyWin);
        result.Add(onlyOneLoss);
        return result;

    }

}
