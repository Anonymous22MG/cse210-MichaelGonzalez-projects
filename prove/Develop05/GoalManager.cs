using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Level: {GetLevel()}");
    }

    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine() ?? "";

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? "";

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? "";

        Console.Write("What is the amount of points associated with this goal? ");
        int points = ReadInt();

        if (goalType == "1")
        {
            Goal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("Simple goal created.");
        }
        else if (goalType == "2")
        {
            Goal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("Eternal goal created.");
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished to be complete? ");
            int target = ReadInt();

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = ReadInt();

            Goal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
            Console.WriteLine("Checklist goal created.");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = ReadInt();

        if (goalNumber < 1 || goalNumber > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[goalNumber - 1];
        int pointsEarned = selectedGoal.RecordEvent();

        if (pointsEarned > 0)
        {
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points.");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("This goal is already complete, so no points were awarded.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine() ?? "";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine() ?? "";

        if (File.Exists(fileName) == false)
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goal goal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                Goal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    private int ReadInt()
    {
        int number;
        string input = Console.ReadLine() ?? "";

        while (int.TryParse(input, out number) == false)
        {
            Console.Write("Please enter a valid number: ");
            input = Console.ReadLine() ?? "";
        }

        return number;
    }
}