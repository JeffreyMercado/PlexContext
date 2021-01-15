using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class HubTemplate
    {
        public long Id { get; set; }
        public string Section { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public long? HomeVisibility { get; set; }
        public long? RecommendedVisibility { get; set; }
        public double? Order { get; set; }
        public string ExtraData { get; set; }
    }
}
