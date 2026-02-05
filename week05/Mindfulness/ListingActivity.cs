using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you list positive things in your life.";

        _prompts = new List<string>();
    }

    protected override void PerformActivity()
    {
    }
}
