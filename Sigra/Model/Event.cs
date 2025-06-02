using System;

public class Event
{
    public DateTime Timestamp { get; set; }
    public string Description { get; set; }

    public Event(string description)
    {
        Timestamp = DateTime.Now;
        Description = description;
    }

    public virtual string GetSummary()
    {
        return $"[{Timestamp}] {Description}";
    }
}
