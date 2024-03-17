using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        
       if (x < 0)
       {
           return false;
       }

       string xToString = x.ToString();

       for(int i = 0; i < xToString.Length / 2 ; i++)
       {
            if (xToString[i] != xToString[xToString.Length-1-i])
            {
                return false;
            }

       }
        
        return true;
    }

}

//Meine Gedanken zur Lösung
/*
1221
Länge 4
index 0 1 2 3
string 1 2 2 1
for schleife mit i
erste  Runde i ist   0
zweite Runde i ist   1
dritte Runde i ist   2
vierte Runde i ist   3
Vergleich:
if (1 != 1)
4(Länge) - 1 = 3 -i((index 0))
return false
if (2 != 2)
    i = 1
4 - 1 - i = 2
return false
*/