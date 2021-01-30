using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Dlna
{
    public partial class ShortKey
    {
        public string ShaKeyId { get; set; }
        public string PlexPath { get; set; }
        public string PlexKey { get; set; }
        public string Content { get; set; }
        public long? LastAccessedTimeT { get; set; }
        public string MachineIdentifier { get; set; }
    }
}
