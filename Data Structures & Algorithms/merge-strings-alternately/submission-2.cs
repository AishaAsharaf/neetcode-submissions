public class Solution {
    public string MergeAlternately(string word1, string word2) {
       StringBuilder result = new StringBuilder();
       int lastindex = 0;
       for(int n = 0 ; n < Math.Min(word1.Length,word2.Length); n++){
               result.Append(word1[n]);
               result.Append(word2[n]);
               lastindex = n+1;
          
       }
       if(word1.Length == word2.Length)return result.ToString();
       else if(word1.Length > word2.Length)
       {
        return result.Append(word1.Substring(lastindex)).ToString();
       }
       else
       {
         return result.Append(word2.Substring(lastindex)).ToString();
       };

    }
}