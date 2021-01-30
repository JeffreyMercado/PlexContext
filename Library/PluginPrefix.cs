using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext.Library
{
    public partial class PluginPrefix
    {
        public long Id { get; set; }
        public long? PluginId { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string ArtUrl { get; set; }
        public string ThumbUrl { get; set; }
        public string TitlebarUrl { get; set; }
        public bool? Share { get; set; }
        public bool? HasStoreServices { get; set; }
        public bool? Prefs { get; set; }
    }
}
