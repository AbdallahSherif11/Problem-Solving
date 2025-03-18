public class Solution 
{
    public string Interpret(string command) 
    {
        string outputString = "";

        for(int i = 0; i < command.Length; i++)
        {
            if(command[i] == 'G')
            {
                outputString += 'G';
            }
            else if(command[i] == '(')
            {
                if (command[i+1] == ')')
                {
                    outputString += 'o';
                }
                else
                {
                    outputString += "al";
                }
            }
        }

        return outputString;
    }
}
