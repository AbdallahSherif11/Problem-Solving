public class OrderedStream
{
    Dictionary<int, string> X;
    int i;
    int N;
    public OrderedStream(int n)
    {
        X = new Dictionary<int, string>(n);
        for(int z = 1; z <= n; z++)
        {
            X.Add(z, "");
        }
        i = 1;
        N = n;
    }

    public IList<string> Insert(int idKey, string value)
    {
        X[idKey] = value;
        List<string> Result = new List<string>();
        while (X[i] != "")
        {
            Result.Add(X[i]);
            i++;
            if(i > N)
            {
                break;
            }
        }

        return Result;
    }
}