using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Plugin
    {
        public long Id { get; set; }
        public string Identifier { get; set; }
        public long? FrameworkVersion { get; set; }
        public long? AccessCount { get; set; }
        public DateTime? InstalledAt { get; set; }
        public DateTime? AccessedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
