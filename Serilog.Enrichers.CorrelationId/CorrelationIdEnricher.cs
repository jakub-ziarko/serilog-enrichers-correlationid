using Serilog.Core;
using Serilog.Events;

namespace Serilog.Enrichers.CorrelationId
{
    public class CorrelationIdEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            propertyFactory.CreateProperty("CorrelationId", null);
        }
    }
}
