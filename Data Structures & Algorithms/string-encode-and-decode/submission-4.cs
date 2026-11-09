public class Solution {

    public string Encode(IList<string> strs) {
        
        StringBuilder encode = new StringBuilder();
        foreach (string s in strs) {
            encode.Append(s.Length).Append('#').Append(s);
        }
        return encode.ToString();
    }

    public List<string> Decode(string s) {
         List<string> newlist = new List<string>();
         int i = 0;
         while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));
            i = j + 1;
            j = i + length;
            newlist.Add(s.Substring(i,length));
            i = j;
         }
         return newlist;
   }
}
