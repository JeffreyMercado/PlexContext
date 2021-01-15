using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class StatisticsMedium
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? DeviceId { get; set; }
        public long? Timespan { get; set; }
        public DateTime? At { get; set; }
        public long? MetadataType { get; set; }
        public long? Count { get; set; }
        public long? Duration { get; set; }
    }
}
