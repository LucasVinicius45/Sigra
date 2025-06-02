namespace Sigra.Model
{
    public class Alert
    {
        public static bool ShouldTriggerAlert(PowerFailure failure)
        {
            return failure.CriticalRegion || !string.IsNullOrEmpty(failure.CyberImpact);
        }

        public static string GetMessage(PowerFailure failure)
        {
            return $"🚨 ALERTA: Falha registrada em {failure.Location} com possível risco: {failure.CyberImpact}";
        }
    }
}
