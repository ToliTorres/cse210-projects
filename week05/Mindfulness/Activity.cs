using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
    }

    protected void DisplayEndingMessage()
    {
    }

    protected void Pause(int seconds)
    {
    }

    protected abstract void PerformActivity();
}
