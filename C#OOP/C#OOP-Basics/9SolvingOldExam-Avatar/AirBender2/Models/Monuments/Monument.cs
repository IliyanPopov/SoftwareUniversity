﻿public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public abstract int GetAffinityPoints();
}