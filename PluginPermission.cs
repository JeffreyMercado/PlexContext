using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class PluginPermission
    {
        public long Id { get; set; }
        public long? PluginId { get; set; }
        public long? AccountId { get; set; }
        public long? Permission { get; set; }
    }
}
