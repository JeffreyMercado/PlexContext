using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Device
    {
        public long Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Platform { get; set; }
    }
}
