public class Solution {
    public bool IsValid(string s) {
       Stack<char> stack = new Stack<char>();
       Dictionary<char,char> dict = new Dictionary<char,char>{
        {')','('},
        {'}','{'},
        {']','['}
       };
       foreach(char t in s){
           if(dict.ContainsKey(t)){
              if(stack.Count > 0 && stack.Peek() == dict[t]){
                stack.Pop();
              }else{
                return false;
              }
           }
           else
           {
            stack.Push(t);
           }
       }
       return stack.Count == 0;
    }
}
