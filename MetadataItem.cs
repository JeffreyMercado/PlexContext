using System;
using System.Collections.Generic;

#nullable disable

namespace PlexContext
{
    public partial class MetadataItem
    {
        public MetadataItem()
        {
            MetadataItemClusterings = new HashSet<MetadataItemClustering>();
        }

        public long Id { get; set; }
        public long? LibrarySectionId { get; set; }
        public long? ParentId { get; set; }
        public long? MetadataType { get; set; }
        public string Guid { get; set; }
        public long? MediaItemCount { get; set; }
        public string Title { get; set; }
        public string TitleSort { get; set; }
        public string OriginalTitle { get; set; }
        public string Studio { get; set; }
        public double? Rating { get; set; }
        public long? RatingCount { get; set; }
        public string Tagline { get; set; }
        public string Summary { get; set; }
        public string Trivia { get; set; }
        public string Quotes { get; set; }
        public string ContentRating { get; set; }
        public long? ContentRatingAge { get; set; }
        public long? Index { get; set; }
        public long? AbsoluteIndex { get; set; }
        public long? Duration { get; set; }
        public string UserThumbUrl { get; set; }
        public string UserArtUrl { get; set; }
        public string UserBannerUrl { get; set; }
        public string UserMusicUrl { get; set; }
        public string UserFields { get; set; }
        public string TagsGenre { get; set; }
        public string TagsCollection { get; set; }
        public string TagsDirector { get; set; }
        public string TagsWriter { get; set; }
        public string TagsStar { get; set; }
        public DateTime? OriginallyAvailableAt { get; set; }
        public DateTime? AvailableAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime? RefreshedAt { get; set; }
        public long? Year { get; set; }
        public DateTime? AddedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string TagsCountry { get; set; }
        public string ExtraData { get; set; }
        public string Hash { get; set; }
        public double? AudienceRating { get; set; }
        public long? ChangedAt { get; set; }
        public long? ResourcesChangedAt { get; set; }
        public long? Remote { get; set; }

        public virtual ICollection<MetadataItemClustering> MetadataItemClusterings { get; set; }
    }
}
