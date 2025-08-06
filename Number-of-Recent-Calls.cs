public class RecentCounter
{
    int Counter;

    List<int> Requests;
    public RecentCounter()
    {
        Counter = 0;
        Requests = new List<int>();
    }

    public int Ping(int t)
    {
        Requests.Add(t);

        Counter = Requests.Count(X => (X >= t - 3000) && (X <= t));

        return Counter;
    }
}