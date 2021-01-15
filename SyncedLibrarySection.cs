﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SyncedLibrarySection
    {
        public long Id { get; set; }
        public long? SyncListId { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? ChangedAt { get; set; }
        public long? ReferenceCount { get; set; }
        public long? FirstPackagedAt { get; set; }
        public long? State { get; set; }
    }
}
