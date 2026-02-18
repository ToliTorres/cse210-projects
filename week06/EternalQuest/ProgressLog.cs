using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ProgressLog
{
    private string _filePath = "log.txt";

    public void TrimLog(int maxLines = 1000)
    {
        if (!File.Exists(_filePath)) return;

        var lines = File.ReadAllLines(_filePath);

        if (lines.Length > maxLines)
        {
            File.WriteAllLines(_filePath, lines.TakeLast(maxLines));
        }
    }

    public void AddEntry(string message)
    {
        string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        File.AppendAllText(_filePath, entry + Environment.NewLine);

        TrimLog();
    }


    public void ShowLog()
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine("No log history found.");
            return;
        }

        var lines = File.ReadAllLines(_filePath);

        Console.WriteLine("\n===== LAST 10 EVENTS =====");

        foreach (var line in lines.TakeLast(10))
        {
            Console.WriteLine(line);
        }
    }
}
