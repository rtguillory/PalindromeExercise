﻿using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var word = new WordSmith();

            Console.WriteLine(word.IsAPalindrome("tacocat"));
        }
    }
}
