public class RomanToInteger
{
    public int TransformRomanToInt(string s)
    {

        Dictionary<char, int> romanMap = new Dictionary<char, int>();
        romanMap.Add('I', 1);
        romanMap.Add('V', 5);
        romanMap.Add('X', 10);
        romanMap.Add('L', 50);
        romanMap.Add('C', 100);
        romanMap.Add('D', 500);
        romanMap.Add('M', 1000);

        char[] sToChar = s.ToCharArray();
        int romanToInt = 0;

        for (int i = sToChar.Length - 1; i >= 0; i--)
        {
            //first Value always Addition to avoid System.IndexOutOfRangeException
            if (i == sToChar.Length - 1)
            {
                romanToInt += romanMap[sToChar[i]];
            }
            //Subtraktion
            else if (romanMap[sToChar[i]] < romanMap[sToChar[i + 1]])
            {
                romanToInt -= romanMap[sToChar[i]];
            }
            //Addition
            else
            {
                romanToInt += romanMap[sToChar[i]];
            }
        }

        return romanToInt;
    }
}

//Hint: Problem is simpler to solve by working the string from back to front and using a map.
//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000