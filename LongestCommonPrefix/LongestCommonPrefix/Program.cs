// See https://aka.ms/new-console-template for more information

Solution test = new Solution();
String[] input = { "flower", "flow", "flight" };
string output = test.LongestCommonPrefix(input);
Console.WriteLine(output);

public class Solution
{
    public string LongestCommonPrefix(string[] input)
    {
        Array.Sort(input);

        string longestCommonPrefix = string.Empty;
        char[] firstWord = input[0].ToCharArray();
        char[] lastWord = input[input.Length - 1].ToCharArray();

        for (int i = 0; i < firstWord.Length; i++)
        {
            if (firstWord[i] != lastWord[i])
            {
                break;
            }
            else
            {
                longestCommonPrefix = longestCommonPrefix + firstWord[i];
            }

        }


        return longestCommonPrefix;
    }

}

