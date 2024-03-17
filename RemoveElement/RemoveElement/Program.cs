// See https://aka.ms/new-console-template for more information



//Solution sol = new Solution();
int[] array1 = { 4, 5, 6 };
sol.RemoveElement(array1, 2);

Solution2 sol2 = new Solution2();
sol2.RemoveElement(array1, 1);
int[] testArray1 = { 3, 2, 2, 3 };
int[] testArray2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
Console.WriteLine("array1");
int ret1 = sol2.RemoveElement(testArray1, 3);
Console.WriteLine("array2");
int ret2 = sol2.RemoveElement(testArray2, 2);

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int newIndex = 0;
        foreach (int currentNumber in nums)
        {
            if (val != currentNumber)
            {
                nums[newIndex] = currentNumber;
                newIndex++;
            }
        }

        return newIndex++;
    }
}

public class Solution2
{
    public int RemoveElement(int[] nums, int val)
    {
        int newIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (val != nums[i])
            {
                nums[newIndex] = nums[i];
                newIndex++;
            }
        }
        return newIndex;
    }
}