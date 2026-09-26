public class Solution {
    public bool IsAnagram(string s, string t) {
          if(s.Length != t.Length) return false;
          char[] sString = s.ToCharArray();
          char[] tString = t.ToCharArray();
          Array.Sort(sString);
          Array.Sort(tString);
         return sString.SequenceEqual(tString);
    }
}
