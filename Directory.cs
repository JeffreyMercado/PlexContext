using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Directory
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? ParentDirectoryId { get; set; }
        public string Path { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public byte[] DeletedAt { get; set; }
    }
}
