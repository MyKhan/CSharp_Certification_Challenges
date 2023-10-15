﻿Console.WriteLine("All the challenges are in their own files");

string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word) 
{
    string reversedWord = new string(word.Reverse().ToArray());

    bool result = word == reversedWord ? true : false;

    return result;
}