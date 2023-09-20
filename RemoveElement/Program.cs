public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[counter] = nums[i];
                counter++;
            }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 5, 5, 1, 2, 3, 4 };


        Console.WriteLine(RemoveElement(nums,5));
    }
}
