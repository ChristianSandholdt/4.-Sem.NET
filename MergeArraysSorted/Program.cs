public class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int p = m + n - 1;

        while (j >= 0)
        {
            if (i>=0 && nums1[i] > nums2[j])
            {
                nums1[p] = nums1[i];
                p--;
                i--;
            }
            else
            {
                nums1[p] = nums2[j];
                p--;
                j--;
            }
        }
    }


    static void Main(string[] args)
    {
        int[] test1 = { 1, 3, 5, 0, 0, 0 };
        int[] test2 = { 2, 4, 6 };
        Merge(test1, test1.Length, test2, test2.Length);
        foreach (int i in test1)
        {
            Console.WriteLine(i);
        }
    }
}