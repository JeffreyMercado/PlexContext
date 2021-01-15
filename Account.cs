using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public string DefaultAudioLanguage { get; set; }
        public string DefaultSubtitleLanguage { get; set; }
        public byte[] AutoSelectSubtitle { get; set; }
        public byte[] AutoSelectAudio { get; set; }
    }
}
