using System;

namespace Sigra.Model
{
    public class PowerFailure
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string FailureType { get; set; }
        public bool CriticalRegion { get; set; }
        public string CyberImpact { get; set; }

        public PowerFailure(DateTime date, string location, string type, bool isCritical, string cyberImpact)
        {
            Date = date;
            Location = location;
            FailureType = type;
            CriticalRegion = isCritical;
            CyberImpact = cyberImpact;
        }

        public string GetSummary()
        {
            return $"[{Date}] Local: {Location}, Tipo: {FailureType}, Crítica: {CriticalRegion}, Cibernético: {CyberImpact}";
        }
    }
}
