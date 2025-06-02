using System.Collections.Generic;

namespace Sigra.Model
{
    public class Report
    {
        public static string GenerateSummary(List<PowerFailure> failures)
        {
            int total = failures.Count;
            int critical = failures.FindAll(f => f.CriticalRegion).Count;
            int cyber = failures.FindAll(f => !string.IsNullOrEmpty(f.CyberImpact)).Count;

            return $"Total de falhas: {total}, Críticas: {critical}, Cibersegurança envolvida: {cyber}";
        }
    }
}
