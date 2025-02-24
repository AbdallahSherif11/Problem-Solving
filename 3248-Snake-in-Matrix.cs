public class Solution 
{
    public int FinalPositionOfSnake(int n, IList<string> commands) 
    {
        int x = 0;
        for (int i = 0; i < commands.Count; i++)
        {
            switch(commands[i])
            {
                case "RIGHT":
                    x += 1;
                    break;
                case "LEFT":
                    x -= 1;
                    break;
                case "UP":
                    x -= n;
                    break;
                case "DOWN":
                    x += n;
                    break;
            }
        }
        return x;
    }
}