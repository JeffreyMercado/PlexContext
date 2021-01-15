using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class SectionLocation
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public string RootPath { get; set; }
        public byte[] Available { get; set; }
        public byte[] ScannedAt { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
