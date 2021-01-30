using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class Directory
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? ParentDirectoryId { get; set; }
        public string Path { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
