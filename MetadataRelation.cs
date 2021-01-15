using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MetadataRelation
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public long? RelatedMetadataItemId { get; set; }
        public long? RelationType { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
    }
}
