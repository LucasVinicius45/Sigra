public class EventLog : Event
{
    public EventLog(string description) : base(description)
    {
    }

    public override string GetSummary()
    {
        return $"[LOG {Timestamp:HH:mm:ss}] {Description}";
    }
}
