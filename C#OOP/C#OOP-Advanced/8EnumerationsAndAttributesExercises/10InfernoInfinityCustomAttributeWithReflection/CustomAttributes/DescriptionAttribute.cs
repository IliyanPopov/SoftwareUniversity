using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Method,
    AllowMultiple = true)]
public class DescriptionAttribute : Attribute
{
    public DescriptionAttribute(string author, int revision, string description, params string[] reviewers)
    {
        this.Author = author;
        this.Revision = revision;
        this.Description = description;
        this.Reviewers = reviewers;
    }
    public string Author { get; set; }

    public int Revision { get; set; }

    public string Description { get; set; }

    public IList<string> Reviewers { get; set; }
}