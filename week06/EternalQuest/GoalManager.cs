using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    private int _level = 1;
    private ProgressLog _log = new();

    public void Start()
    {
        int choice = -1;

        while (choice != 7)
        {
            Console.WriteLine($"\nScore: {_score} | Level: {_level}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Show Log");
            Console.WriteLine("7. Exit");

            choice = ReadInt();

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
                case 6:
                    Console.Clear();
                    _log.ShowLog();
                    Console.WriteLine("\nPress Enter to return...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }

    int ReadInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
            Console.WriteLine("Invalid number. Try again:");
        return value;
    }

    void CreateGoal()
    {
        Console.WriteLine("\n1 Simple  2 Eternal  3 Checklist  4 Negative");
        int type = ReadInt();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        if (type == 4)
        {
            Console.Write("Penalty Points: ");
            int penalty = ReadInt();
            _goals.Add(new NegativeGoal(name, desc, penalty));
            return;
        }

        Console.Write("Points: ");
        int points = ReadInt();

        if (type == 1)
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == 2)
            _goals.Add(new EternalGoal(name, desc, points));

        else
        {
            Console.Write("Target count: ");
            int target = ReadInt();

            Console.Write("Bonus: ");
            int bonus = ReadInt();

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"\n{i + 1}. {_goals[i].GetDetailsString()}");
    }

    void RecordEvent()
    {
        ListGoals();
        Console.Write("\nSelect goal: ");
        int index = ReadInt() - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal.");
            return;
        }

        Goal goal = _goals[index];
        goal.RecordEvent();

        if (goal is NegativeGoal ng)
        {
            _score -= ng.GetPenalty();
            _log.AddEntry($"Penalty from {goal.GetName()} (-{ng.GetPenalty()} pts)");
        }
        else
        {
            _score += goal.GetPoints();
            _log.AddEntry($"Completed {goal.GetName()} (+{goal.GetPoints()} pts)");

            if (goal is ChecklistGoal cg && cg.IsComplete())
            {
                _score += cg.GetBonus();
                _log.AddEntry($"Bonus earned (+{cg.GetBonus()} pts)");
            }
        }

        if (_score < 0) _score = 0;

        CheckLevelUp();
    }

    void SaveGoals()
    {
        using StreamWriter sw = new("goals.txt");
        sw.WriteLine(_score);
        sw.WriteLine(_level);

        foreach (Goal g in _goals)
            sw.WriteLine(g.GetStringRepresentation());
    }

    void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");

        _goals.Clear();
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));

            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

            else if (type == "NegativeGoal")
                _goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));

            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(
                data[0],
                data[1],
                int.Parse(data[2]),
                int.Parse(data[4]),
                int.Parse(data[3])
            ));
        }
    }

    void CheckLevelUp()
    {
        int newLevel = (_score / 1000) + 1;

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"🎉 LEVEL UP! Now Level {_level}");
            _log.AddEntry($"Level Up to {_level}");
        }
    }
}
