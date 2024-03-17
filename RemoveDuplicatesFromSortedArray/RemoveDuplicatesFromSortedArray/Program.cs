// See https://aka.ms/new-console-template for more information

Solution sol = new Solution();
int[] testArray1 = { 1, 1, 2 };
Solution sol2 = new Solution();
int[] testArray2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(sol.RemoveDuplicates(testArray1));
Console.WriteLine(sol.RemoveDuplicates(testArray2));

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int uniqueNumberCount = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[uniqueNumberCount] != nums[i])
            {
                uniqueNumberCount++;
                nums[uniqueNumberCount] = nums[i];
            }

        }

        return uniqueNumberCount + 1;
    }

}