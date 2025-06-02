public class PowerFailure : Event
{
    public string Location { get; set; }
    public string FailureType { get; set; }
    public bool CriticalRegion { get; set; }
    public string CyberImpact { get; set; }

    public PowerFailure(DateTime date, string location, string type, bool isCritical, string impact)
        : base($"Falha em {location}: {type}")
    {
        Timestamp = date;
        Location = location;
        FailureType = type;
        CriticalRegion = isCritical;
        CyberImpact = impact;
    }

    public override string GetSummary()
    {
        return $"[{Timestamp}] Local: {Location}, Tipo: {FailureType}, Crítica: {CriticalRegion}, Cibernético: {CyberImpact}";
    }
}
