/*
Complete the solution so that it splits the string into pairs of two characters.

If the string contains an odd number of characters then it should replace
the missing second character of the final pair with an underscore ('_').

Examples:

    'abc' =>  ['ab', 'c_']
    'abcdef' => ['ab', 'cd', 'ef']
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SplitString
{
    public static void Main(string[] args)
    {
        string tmp = "";
        foreach (string a in args)
        {
            tmp += a;
        }
        Solution(tmp);
    }
    public static string[] Solution(string str)
    {
        string s = "";
        for (int i = 0; i < str.Length; i += 2)
        {
            s += str[i];
            if (i + 1 < str.Length)
            {
                s += str[i + 1] + " ";
                //Console.WriteLine(s);
            }
        }

        string[] res = s.Split(" ");

        for (int i = 0; i < res.Length; i++)
        {
            if (res[i].Length % 2 != 0)
            {
                res[i] += "_";
            }
        }

        List<string> n = new List<string>();
        for (int i = 0; i < res.Length; i++)
        {
            if (!string.IsNullOrEmpty(res[i]) && res[i] != "  ")
            {
                n.Add(res[i]);
            }
        }
        var v = n.ToArray();
        return v;
    }
}
