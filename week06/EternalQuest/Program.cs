/*
This project exceeds the base requirements by
adding a level progression system,
persistent progress logging with automatic trimming and last-10 display,
negative goals that deduct points,
robust input validation to prevent crashes,
and full data persistence for score, level, and all goal types.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        manager.Start();
    }
}