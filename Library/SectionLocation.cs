using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class SectionLocation
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public string RootPath { get; set; }
        public bool? Available { get; set; }
        public DateTime? ScannedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
