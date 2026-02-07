using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you list positive things in your life.";
    }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("Start listing items:");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
    }
}

