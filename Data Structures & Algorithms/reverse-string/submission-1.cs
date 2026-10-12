public class Solution {
    public void ReverseString(char[] s) {
        int k = 0;
        int last = s.Length - 1;
        while(k<last)
        {
        char temp = s[k];
        s[k] = s[last];
        s[last] = temp;
        k++;
        last--;
        }
    }
}