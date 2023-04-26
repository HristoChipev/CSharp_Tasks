using System;
using System.Collections;
using System.Linq;
using CSharp_Tasks;

// Join two strings zipper style
Console.WriteLine(JoinStrs.joinStrings("abc", "rtqwwe"));

// Palindrome
Console.WriteLine(Palindrome.palindrome("racecar"));
Console.WriteLine(Palindrome.palindrome2(121));

// Fizz Buzz
Array.ForEach(FizzBuzz.fizzBuzz(15), Console.WriteLine);

// Check the sum
Console.WriteLine(CheckSum.checkSum("abc", "cba", "cdb"));
