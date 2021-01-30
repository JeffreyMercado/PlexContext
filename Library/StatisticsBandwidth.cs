using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class StatisticsBandwidth
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? DeviceId { get; set; }
        public long? Timespan { get; set; }
        public DateTime? At { get; set; }
        public bool? Lan { get; set; }
        public long? Bytes { get; set; }
    }
}
