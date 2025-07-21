using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }


    public abstract int RecordEvent();

    public abstract string GetStatus();

    public abstract string GetStringRepresentation();

}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
    : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return IsComplete ? "[X]" : "[ ]";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsComplete}";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }
    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetStringRepresentation()
    {
        return $"Major Workout|{Name}|{Description}|{Points}";
    }
}

public class ChecklistGoal : Goal
{
    private int TargetCount;
    private int CurrentCount;
    private int BonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }
    public void SetCurrentCount(int count)
    {
        CurrentCount = count;
        if (CurrentCount >= TargetCount)
        {
            IsComplete = true;
        }
    }
    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            CurrentCount++;
            if (CurrentCount >= TargetCount)
            {
                IsComplete = true;
                return Points + BonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] Completed {CurrentCount}/{TargetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"Daily Workout|{Name}|{Description}|{Points}|{CurrentCount}|{TargetCount}|{BonusPoints}|{IsComplete}";
    }
}