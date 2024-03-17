Solution test = new Solution();
String input = "()[]{}";
test.IsValid(input);
Console.WriteLine(test.IsValid(input));

public class Solution
{
    public bool IsValid(string s)
    {
        char[] chars = s.ToCharArray();
        Stack<char> myStack = new Stack<char>();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '(')
            {
                myStack.Push(')');
            }
            else if (chars[i] == '{')
            {
                myStack.Push('}');
            }
            else if (chars[i] == '[')
            {
                myStack.Push(']');
            }

            else if (myStack.Count == 0 || myStack.Pop() != chars[i])
            {
                return false;
            }

        }

        if (myStack.Count > 0)
        {
            return false;
        }
        else
        {
            return true;
        }


    }
}