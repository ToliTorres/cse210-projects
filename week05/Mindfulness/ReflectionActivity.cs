using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this experience in the future?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity helps you reflect on times of strength and resilience.";
    }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();

        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
        }
    }
}

