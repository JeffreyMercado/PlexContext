using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Dlna
{
    public partial class ObjectId
    {
        public string Content { get; set; }
        public string ParentObjectId { get; set; }
        public string PlexPath { get; set; }
        public string PlexParentPath { get; set; }
        public string ParentMachineIdentifier { get; set; }
        public long Part { get; set; }
        public long? LastAccessedTimeT { get; set; }
        public string MachineIdentifier { get; set; }
    }
}
