/**
 * @param {string} s
 * @return {number}
 */
var countAsterisks = function(s) {
    var Count = 0;

    for (let i = 0; i < s.length; i++)
    {
        if (s[i] == '|')
        {
            do
            {
                i++;
            } while (s[i] != '|');
        }
        if (s[i] == '*')
        {
            Count++;
        }
    }
    return Count;
};