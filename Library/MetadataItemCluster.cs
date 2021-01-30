using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class MetadataItemCluster
    {
        public MetadataItemCluster()
        {
            MetadataItemClusterings = new HashSet<MetadataItemClustering>();
        }

        public long Id { get; set; }
        public long? ZoomLevel { get; set; }
        public long? LibrarySectionId { get; set; }
        public string Title { get; set; }
        public long? Count { get; set; }
        public DateTime? StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public string ExtraData { get; set; }

        public virtual ICollection<MetadataItemClustering> MetadataItemClusterings { get; set; }
    }
}
