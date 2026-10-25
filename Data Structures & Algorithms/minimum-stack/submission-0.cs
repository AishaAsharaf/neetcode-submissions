public class MinStack {
    List<int> newStack;
    public MinStack() {
        newStack =  new List<int>();
    }
    
    public void Push(int val) {
        newStack.Add(val);
    }
    
    public void Pop() {
        newStack.RemoveAt(newStack.Count - 1);
    }
    
    public int Top() {
        return newStack[newStack.Count - 1];
    }
    
    public int GetMin() {
        return newStack.Min();
    }
}
