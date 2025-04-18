public class Solution 
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) 
    {
        int[] Answer = new int[2];

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    Answer[0]++;
                    break;
                }
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            for (int j = 0; j < nums1.Length; j++)
            {
                if (nums2[i] == nums1[j])
                {
                    Answer[1]++;
                    break;
                }
            }
        }

        return Answer;
    }
}