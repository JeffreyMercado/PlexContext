using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class CloudsyncFile
    {
        public long Id { get; set; }
        public string DeviceIdentifier { get; set; }
        public string OriginalUrl { get; set; }
        public string Provider { get; set; }
        public string NewKey { get; set; }
        public string QueryString { get; set; }
        public string ExtraData { get; set; }
    }
}
