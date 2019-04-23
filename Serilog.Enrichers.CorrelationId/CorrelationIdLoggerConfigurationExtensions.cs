using System;
using Serilog.Configuration;

namespace Serilog.Enrichers.CorrelationId
{
    public static class CorrelationIdLoggerConfigurationExtensions
    {
        public static LoggerConfiguration WithCorrelationId(
            this LoggerEnrichmentConfiguration loggerEnrichmentConfiguration)
        {
            if (loggerEnrichmentConfiguration == null) throw new ArgumentNullException(nameof(loggerEnrichmentConfiguration));
            return loggerEnrichmentConfiguration.With<CorrelationIdEnricher>();
        }

    }
}
