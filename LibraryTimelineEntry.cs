using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class LibraryTimelineEntry
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? MetadataItemId { get; set; }
        public long? State { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
