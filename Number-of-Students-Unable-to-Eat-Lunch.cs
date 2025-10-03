public class Solution 
{
    public int CountStudents(int[] students, int[] sandwiches) 
    {
        Queue<int> Students = new Queue<int>();
        foreach (int student in students)
        {
            Students.Enqueue(student);
        }
        Stack<int> Sandwiches = new Stack<int>();
        
        for(int i = sandwiches.Length - 1; i >=0; i--)
        {
            Sandwiches.Push(sandwiches[i]);
        }

        while (Students.Count > 0 && Students.Contains(Sandwiches.Peek()))
        {
            if (Students.Peek() == Sandwiches.Peek())
            {
                Sandwiches.Pop();
                Students.Dequeue();
            }
            else
            {
                int X = Students.Dequeue();
                Students.Enqueue(X);
            }
        }


        return Students.Count;
    }
}