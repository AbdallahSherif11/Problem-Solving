public class Solution 
{
    public string DecodeMessage(string key, string message) 
    {
        Dictionary<char, char> Decoder = new Dictionary<char, char>();
        Decoder.Add(' ', ' ');
        char letter = 'a';
        char[] keyArr = key.ToCharArray();
        char[] messageArr = message.ToCharArray();
        string Result = "";

        for (int i = 0; i < keyArr.Length; i++)
        {
            if (Decoder.ContainsKey(keyArr[i]))
                continue;

            Decoder.Add(keyArr[i], letter++);
        }
        for (int i = 0; i < messageArr.Length; i++)
        {
            Result += Decoder[messageArr[i]];
        }

        return Result;
    }
}