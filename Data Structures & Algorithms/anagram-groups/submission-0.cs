public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string,List<string>>();
        foreach(var s in strs){
            char[] sort = s.ToCharArray();
            Array.Sort(sort);
            string sorted = new string(sort);

            if(!res.ContainsKey(sorted)){
                res[sorted] = new List<string>();
            }
            res[sorted].Add(s);
        }        
        return res.Values.ToList<List<string>>();
        
    }
}
