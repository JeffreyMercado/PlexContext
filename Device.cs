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
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public byte[] Platform { get; set; }
    }
}
