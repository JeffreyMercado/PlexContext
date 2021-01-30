using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MetadataRelation
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public long? RelatedMetadataItemId { get; set; }
        public long? RelationType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
