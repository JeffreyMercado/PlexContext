using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class ViewSetting
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public string ClientType { get; set; }
        public string ViewGroup { get; set; }
        public long? ViewId { get; set; }
        public long? SortId { get; set; }
        public bool? SortAsc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
