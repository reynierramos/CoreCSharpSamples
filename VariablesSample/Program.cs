﻿using System;
using static System.Console;

namespace VariablesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Bugs Bunny";
            var age = 37;
            var isRabbit = true;
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();
            WriteLine($"name is type {nameType}");
            WriteLine($"age is type {ageType}");
            WriteLine($"isRabbit is type {isRabbitType}");
        }
    }
}