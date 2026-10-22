public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> record = new Stack<int>();
        int sum = 0;
        for(int i = 0; i < operations.Length ; i++){
            if(operations[i] == "+")
            {   
                int a = record.Pop();
                int b = record.Peek();
                record.Push(a);
                record.Push(a + b);
                sum += (a+b);
            }
            else if (operations[i] == "D")
            {
                 int b = record.Peek();
                 record.Push(2 * b);
                 sum += (2*b);
            }
            else if (operations[i] == "C")
            {   
                 int c = record.Peek();
                 record.Pop();
                 sum -= c;
            }
            else
            {   
                int b = int.Parse(operations[i]);
                record.Push(b);
                sum += b;
            }
        }
        return sum;
    }
}