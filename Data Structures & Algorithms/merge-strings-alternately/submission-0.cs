public class Solution {
    public string MergeAlternately(string word1, string word2) {
       string newString = "";
       int lastindex = 0;
       for(int n = 0 ; n < Math.Min(word1.Length,word2.Length); n++){
               newString += word1[n];
               newString += word2[n];
               lastindex = n+1;
          
       }
       if(word1.Length == word2.Length)return newString;
       else if(word1.Length > word2.Length)
       {
        return newString += word1.Substring(lastindex);
       }
       else
       {
         return newString += word2.Substring(lastindex);
       };

    }
}