using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity helps you reflect on meaningful experiences.";

        _prompts = new List<string>();
        _questions = new List<string>();
    }

    protected override void PerformActivity()
    {
    }
}
