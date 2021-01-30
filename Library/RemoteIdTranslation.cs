using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class RemoteIdTranslation
    {
        public long Id { get; set; }
        public long? Type { get; set; }
        public long? LocalId { get; set; }
        public string RemoteId { get; set; }
    }
}
