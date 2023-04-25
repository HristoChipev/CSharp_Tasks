// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Linq;

// Join two strings zipper style
Console.WriteLine(joinStrings("abc", "rtqwwe"));

static string joinStrings(string str1, string str2)
{
    string res = "";
    int diffInLenght = Math.Abs(str1.Length - str2.Length);

    for (int i = 0; i < (str1.Length > str2.Length ? str2.Length : str1.Length); i++)
    {
        res += str1[i];
        res += str2[i];
    }

    if (str1.Length > str2.Length)
    {
        res += str1.Substring(str1.Length - diffInLenght);
    }
    else if (str1.Length < str2.Length)
    {
        res += str2.Substring(str2.Length - diffInLenght);
    }

    return res;
}

// Palindrome
Console.WriteLine(palindrome("racecar"));
Console.WriteLine(palindrome2(121));

static bool palindrome(string str)
{
    bool res = false;
    string rev = "";

    rev = string.Join("", str.ToString().Split("").Reverse());

    if (rev == str)
    {
        res = true;
    }

    return res;
}

static bool palindrome2(int n)
{
    bool res = false;
    int copyOfN = n;
    string rev = "";

    while (copyOfN > 0)
    {
        rev += copyOfN % 10;
        copyOfN = copyOfN / 10;
    }

    if (int.Parse(rev) == n)
    {
        res = true;
    }

    return res;
}

// Fizz Buzz
Array.ForEach(fizzBuzz(15), Console.WriteLine);

static string[] fizzBuzz(int n)
{
    string[] arr = new string[n];
    string res = "";

    for (int i = 0; i < n; i++)
    {
        if ((i + 1) % 3 == 0) res += "Fizz";
        if ((i + 1) % 5 == 0) res += "Buzz";

        if (res != "") arr[i] = res;
        else arr[i] = (i + 1).ToString();
        res = "";
    }

    return arr;
}

// Check the sum
Console.WriteLine(checkSum("abc", "cba", "cdb"));

static bool checkSum(string str1, string str2, string targetStr)
{
    int sum = 0;
    int targetSum = 0;

    foreach (char ch in str1)
    {
        if ((int)ch >= 97 && (int)ch <= 122)
        {
            sum += (int)ch - 97;
        }
    }

    foreach (char ch in str2)
    {
        if ((int)ch >= 97 && (int)ch <= 122)
        {
            sum += (int)ch - 97;
        }
    }

    foreach (char ch in targetStr)
    {
        if ((int)ch >= 97 && (int)ch <= 122)
        {
            targetSum += (int)ch - 97;
        }
    }

    return sum == targetSum;
}