using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class ExternalMetadataItem
    {
        public long? Id { get; set; }
        public long? ExternalMetadataSourceId { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? MetadataType { get; set; }
        public string Guid { get; set; }
        public string Title { get; set; }
        public string ParentTitle { get; set; }
        public long? Year { get; set; }
        public long? AddedAt { get; set; }
        public long? UpdatedAt { get; set; }
        public string ExtraData { get; set; }

        public virtual ExternalMetadataSource ExternalMetadataSource { get; set; }
    }
}
