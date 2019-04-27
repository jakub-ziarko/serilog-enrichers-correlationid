using System;
using Serilog.Configuration;
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


    public static class CorrelationIdLoggerConfigurationExtensions
    {
        public static LoggerConfiguration WithCorrelationId(
            this LoggerEnrichmentConfiguration loggerEnrichmentConfiguration)
        {
            if (loggerEnrichmentConfiguration == null) throw new ArgumentNullException(nameof(loggerEnrichmentConfiguration));
            return loggerEnrichmentConfiguration.With<CorrelationIdEnricher>();
        }

    }

    public class CorrelationIdEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            propertyFactory.CreateProperty("CorrelationId", "asdadadasdafjasfljashfasljhfsa");
        }
    }
}
