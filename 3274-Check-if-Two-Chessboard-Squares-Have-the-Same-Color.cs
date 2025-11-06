public class Solution 
{
    public bool CheckTwoChessboards(string coordinate1, string coordinate2) 
    {
        Dictionary<string, byte> ChessBoard = new Dictionary<string, byte>();
        char[] Letters1 = ['a', 'c', 'e', 'g'];
        char[] Letters2 = ['b', 'd', 'f', 'h'];
        foreach (char c in Letters1)
        {
            for(int i = 1; i <= 7; i+=2)
            {
                ChessBoard.Add($"{c}{i}", 0);
            }
            for (int j = 2; j <= 8; j+=2)
            {
                ChessBoard.Add($"{c}{j}", 1);
            }
        }
        foreach (char c in Letters2)
        {
            for (int i = 1; i <= 7; i += 2)
            {
                ChessBoard.Add($"{c}{i}", 1);
            }
            for (int j = 2; j <= 8; j += 2)
            {
                ChessBoard.Add($"{c}{j}", 0);
            }
        }
        if (ChessBoard[coordinate1] == ChessBoard[coordinate2])
        {
            return true;
        }
        return false;
    }
}
