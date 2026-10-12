public class Solution {
    public bool IsPalindrome(string s) {
      string newString = "";
      foreach(char x in s){
        if(char.IsLetterOrDigit(x)){
            newString += char.ToLower(x);
        }
      }
      return newString == new String(newString.Reverse().ToArray());

    }
}
