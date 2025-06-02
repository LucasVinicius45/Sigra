using System;

namespace Sigra.Model
{
    public class EventLog
    {
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }

        public EventLog(string description)
        {
            Timestamp = DateTime.Now;
            Description = description;
        }

        public string GetEntry()
        {
            return $"[{Timestamp:HH:mm:ss}] {Description}";
        }
    }
}
