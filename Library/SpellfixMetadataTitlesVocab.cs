using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class SpellfixMetadataTitlesVocab
    {
        public long Id { get; set; }
        public long? Rank { get; set; }
        public long? Langid { get; set; }
        public string Word { get; set; }
        public string K1 { get; set; }
        public string K2 { get; set; }
    }
}
