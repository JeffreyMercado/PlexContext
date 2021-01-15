using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class LibrarySectionPermission
    {
        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? AccountId { get; set; }
        public long? Permission { get; set; }
    }
}
