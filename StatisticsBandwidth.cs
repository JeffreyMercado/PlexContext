using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class StatisticsBandwidth
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? DeviceId { get; set; }
        public long? Timespan { get; set; }
        public byte[] At { get; set; }
        public byte[] Lan { get; set; }
        public long? Bytes { get; set; }
    }
}
