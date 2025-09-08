public class Solution 
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2) 
    {
        List<int> Result = new List<int>();
        List<int> arr1List = arr1.ToList();
        foreach (int i in arr2)
        {
            List<int> temp = arr1.Where(x => x == i).ToList();
            Result.AddRange(temp);
            arr1List.RemoveAll(x => x == i);
        }
        arr1List.Sort();
        Result.AddRange(arr1List);

        return Result.ToArray();
    }
}
