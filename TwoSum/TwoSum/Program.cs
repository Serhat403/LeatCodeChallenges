// See https://aka.ms/new-console-template for more information

Solution sol = new Solution();
int[] array1 = { 2, 7, 11, 15 };
int[] array2 = { 3, 2, 4 };
int[] array3 = { 3, 3 };

int[] resultArray = sol.TwoSum(array1, 9);
int[] resultArray2 = sol.TwoSum(array2, 6);
int[] resultArray3 = sol.TwoSum(array3, 6);

Console.WriteLine(resultArray[0] + "," + resultArray[1]);
Console.WriteLine(resultArray2[0] + "," + resultArray2[1]);
Console.WriteLine(resultArray3[0] + "," + resultArray3[1]);

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] resultArray = new int[2];
        for (int counter = 0; counter < nums.Length; counter++)
        {
            for (int oneAhead = counter + 1; oneAhead < nums.Length; oneAhead++)
            {
                if (nums[counter] + nums[oneAhead] == target)
                {
                    resultArray[0] = counter;
                    resultArray[1] = oneAhead;
                    return resultArray;
                }
            }

        }

        return resultArray;
    }
}

