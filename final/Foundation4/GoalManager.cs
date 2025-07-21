using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private const string saveFileName = "goals.txt";

    public int GetScore()
    {
        return totalScore;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a workout type:");
        Console.WriteLine("1. Aerobic");
        Console.WriteLine("2. Major Workout or Event");
        Console.WriteLine("3. Daily Workout");
        Console.Write("Your workout type: ");
        string choice = Console.ReadLine();

        Console.Write("Enter workout name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter number of times to complete workout rep: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on Completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
        }

    }
    public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name} - {goals[i].Description}");
        }
    }

    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No Goals to Record.");
            return;
        }

        DisplayGoals();
        Console.Write("Enter the number of the goal you accomplished: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
        {
            int earned = goals[index - 1].RecordEvent();
            totalScore += earned;
            Console.WriteLine($"You earned {earned} points! Total score: {totalScore}");
        }

        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(saveFileName))
        {
            writer.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        if (!File.Exists(saveFileName))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        string[] lines = File.ReadAllLines(saveFileName);
        if (lines.Length == 0)
        {
            Console.WriteLine("Save file is empty.");
            return;
        }

        goals.Clear();
        totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = CreateGoalFromString(lines[i]);
            if (goal != null)
            {
                goals.Add(goal);
            }
        }
        Console.WriteLine("Goals are brought up.");
    }
    public Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split('|');
        if (parts.Length == 0)
            return null;

        string type = parts[0];
        try
        {
            switch (type)
            {
                case "SimpleGoal":
                    return new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])
                    )
                    {
                        IsComplete = bool.Parse(parts[4])
                    };

                case "ChecklistGoal":
                    ChecklistGoal cg = new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])
                    );

                    cg.SetCurrentCount(int.Parse(parts[4]));
                    cg.IsComplete = bool.Parse(parts[7]);
                    return cg;
                
                case "EternalGoal":
                    return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

                default:
                    return null;
            }
        }
        catch
        {
            Console.WriteLine("Error bring up goal:" + data);
            return null;
        }
    }
}