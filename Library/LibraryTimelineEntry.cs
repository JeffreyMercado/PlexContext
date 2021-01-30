using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class LibraryTimelineEntry
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? MetadataItemId { get; set; }
        public long? State { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
