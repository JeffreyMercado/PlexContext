using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MetadataItemClustering
    {
        public long Id { get; set; }
        public long? MetadataItemId { get; set; }
        public long? MetadataItemClusterId { get; set; }
        public long? Index { get; set; }
        public long? Version { get; set; }

        public virtual MetadataItem MetadataItem { get; set; }
        public virtual MetadataItemCluster MetadataItemCluster { get; set; }
    }
}
