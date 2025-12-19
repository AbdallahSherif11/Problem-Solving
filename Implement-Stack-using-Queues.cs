1public class MyStack
2{
3    Queue<int> start;
4
5    public MyStack()
6    {
7        start = new Queue<int>();
8    }
9
10    public void Push(int x)
11    {
12        start.Enqueue(x);
13        
14    }
15
16    public int Pop()
17    {
18        start = new Queue<int>(start.Reverse());
19        int Result = start.Dequeue();
20        start = new Queue<int>(start.Reverse());
21        return Result;
22    }
23
24    public int Top()
25    {
26        var Temp = new Queue<int>(start.Reverse());
27        return Temp.Peek();
28    }
29
30    public bool Empty()
31    {
32        if(start.Count == 0) return true;
33        return false;
34    }
35}
36
37/**
38 * Your MyStack object will be instantiated and called as such:
39 * MyStack obj = new MyStack();
40 * obj.Push(x);
41 * int param_2 = obj.Pop();
42 * int param_3 = obj.Top();
43 * bool param_4 = obj.Empty();
44 */