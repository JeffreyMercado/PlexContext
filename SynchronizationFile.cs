using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SynchronizationFile
    {
        public long Id { get; set; }
        public string ClientIdentifier { get; set; }
        public long? SyncListId { get; set; }
        public long? SyncItemId { get; set; }
        public string ItemUri { get; set; }
        public long? NumParts { get; set; }
        public long? State { get; set; }
        public long? StateContext { get; set; }
        public string ExtraData { get; set; }
    }
}
