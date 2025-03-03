public class Solution 
{
    public IList<int> FindWordsContaining(string[] words, char x) 
    {
        IList<int> result = new List<int>();

        for( int i = 0; i < words.Length; i++ )
        {
            for( int j = 0; j < words[i].Length; j++)
            {
                if ( words[i][j] == x )
                {
                    result.Add(i);
                    break;
                }
            }
        }

        return result;
    }
}
