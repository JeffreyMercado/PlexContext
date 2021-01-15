using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class StatisticsResource
    {
        public long Id { get; set; }
        public long? Timespan { get; set; }
        public DateTime? At { get; set; }
        public double? HostCpuUtilization { get; set; }
        public double? ProcessCpuUtilization { get; set; }
        public double? HostMemoryUtilization { get; set; }
        public double? ProcessMemoryUtilization { get; set; }
    }
}
