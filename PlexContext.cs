using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PlexContext
{
    public partial class PlexContext : DbContext
    {
        public PlexContext()
        {
        }

        public PlexContext(DbContextOptions<PlexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Blob> Blobs { get; set; }
        public virtual DbSet<CloudsyncFile> CloudsyncFiles { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<ExternalMetadataItem> ExternalMetadataItems { get; set; }
        public virtual DbSet<ExternalMetadataSource> ExternalMetadataSources { get; set; }
        public virtual DbSet<Fts4MetadataTitlesDocsize> Fts4MetadataTitlesDocsizes { get; set; }
        public virtual DbSet<Fts4MetadataTitlesSegdir> Fts4MetadataTitlesSegdirs { get; set; }
        public virtual DbSet<Fts4MetadataTitlesSegment> Fts4MetadataTitlesSegments { get; set; }
        public virtual DbSet<Fts4MetadataTitlesStat> Fts4MetadataTitlesStats { get; set; }
        public virtual DbSet<Fts4TagTitlesDocsize> Fts4TagTitlesDocsizes { get; set; }
        public virtual DbSet<Fts4TagTitlesSegdir> Fts4TagTitlesSegdirs { get; set; }
        public virtual DbSet<Fts4TagTitlesSegment> Fts4TagTitlesSegments { get; set; }
        public virtual DbSet<Fts4TagTitlesStat> Fts4TagTitlesStats { get; set; }
        public virtual DbSet<HubTemplate> HubTemplates { get; set; }
        public virtual DbSet<LibrarySection> LibrarySections { get; set; }
        public virtual DbSet<LibrarySectionPermission> LibrarySectionPermissions { get; set; }
        public virtual DbSet<LibraryTimelineEntry> LibraryTimelineEntries { get; set; }
        public virtual DbSet<Locatable> Locatables { get; set; }
        public virtual DbSet<LocationPlace> LocationPlaces { get; set; }
        public virtual DbSet<LocationsNode> LocationsNodes { get; set; }
        public virtual DbSet<LocationsParent> LocationsParents { get; set; }
        public virtual DbSet<LocationsRowid> LocationsRowids { get; set; }
        public virtual DbSet<MediaGrab> MediaGrabs { get; set; }
        public virtual DbSet<MediaItem> MediaItems { get; set; }
        public virtual DbSet<MediaItemSetting> MediaItemSettings { get; set; }
        public virtual DbSet<MediaMetadataMapping> MediaMetadataMappings { get; set; }
        public virtual DbSet<MediaPart> MediaParts { get; set; }
        public virtual DbSet<MediaPartSetting> MediaPartSettings { get; set; }
        public virtual DbSet<MediaProviderResource> MediaProviderResources { get; set; }
        public virtual DbSet<MediaStream> MediaStreams { get; set; }
        public virtual DbSet<MediaStreamSetting> MediaStreamSettings { get; set; }
        public virtual DbSet<MediaSubscription> MediaSubscriptions { get; set; }
        public virtual DbSet<MetadataItem> MetadataItems { get; set; }
        public virtual DbSet<MetadataItemAccount> MetadataItemAccounts { get; set; }
        public virtual DbSet<MetadataItemCluster> MetadataItemClusters { get; set; }
        public virtual DbSet<MetadataItemClustering> MetadataItemClusterings { get; set; }
        public virtual DbSet<MetadataItemSetting> MetadataItemSettings { get; set; }
        public virtual DbSet<MetadataItemView> MetadataItemViews { get; set; }
        public virtual DbSet<MetadataRelation> MetadataRelations { get; set; }
        public virtual DbSet<MetadataSubscriptionDesiredItem> MetadataSubscriptionDesiredItems { get; set; }
        public virtual DbSet<PlayQueue> PlayQueues { get; set; }
        public virtual DbSet<PlayQueueGenerator> PlayQueueGenerators { get; set; }
        public virtual DbSet<PlayQueueItem> PlayQueueItems { get; set; }
        public virtual DbSet<Plugin> Plugins { get; set; }
        public virtual DbSet<PluginPermission> PluginPermissions { get; set; }
        public virtual DbSet<PluginPrefix> PluginPrefixes { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<RemoteIdTranslation> RemoteIdTranslations { get; set; }
        public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }
        public virtual DbSet<SectionLocation> SectionLocations { get; set; }
        public virtual DbSet<SpellfixMetadataTitlesVocab> SpellfixMetadataTitlesVocabs { get; set; }
        public virtual DbSet<SpellfixTagTitlesVocab> SpellfixTagTitlesVocabs { get; set; }
        public virtual DbSet<StatisticsBandwidth> StatisticsBandwidths { get; set; }
        public virtual DbSet<StatisticsMedium> StatisticsMedia { get; set; }
        public virtual DbSet<StatisticsResource> StatisticsResources { get; set; }
        public virtual DbSet<StreamType> StreamTypes { get; set; }
        public virtual DbSet<SyncSchemaVersion> SyncSchemaVersions { get; set; }
        public virtual DbSet<SyncedAncestorItem> SyncedAncestorItems { get; set; }
        public virtual DbSet<SyncedLibrarySection> SyncedLibrarySections { get; set; }
        public virtual DbSet<SyncedMetadataItem> SyncedMetadataItems { get; set; }
        public virtual DbSet<SyncedPlayQueueGenerator> SyncedPlayQueueGenerators { get; set; }
        public virtual DbSet<SynchronizationFile> SynchronizationFiles { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tagging> Taggings { get; set; }
        public virtual DbSet<VersionedMetadataItem> VersionedMetadataItems { get; set; }
        public virtual DbSet<ViewSetting> ViewSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.Name, "index_accounts_on_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutoSelectAudio)
                    .HasColumnType("boolean")
                    .HasColumnName("auto_select_audio")
                    .HasDefaultValueSql("'t'");

                entity.Property(e => e.AutoSelectSubtitle)
                    .HasColumnType("boolean")
                    .HasColumnName("auto_select_subtitle")
                    .HasDefaultValueSql("'t'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DefaultAudioLanguage)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("default_audio_language");

                entity.Property(e => e.DefaultSubtitleLanguage)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("default_subtitle_language");

                entity.Property(e => e.HashedPassword)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hashed_password");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(e => e.Salt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("salt");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Blob>(entity =>
            {
                entity.ToTable("blobs");

                entity.HasIndex(e => e.LinkedType, "index_blobs_on_linked_type");

                entity.HasIndex(e => new { e.LinkedType, e.LinkedGuid, e.BlobType }, "index_blobs_on_linked_type_linked_guid_and_blob_type")
                    .IsUnique();

                entity.HasIndex(e => new { e.LinkedType, e.LinkedId, e.BlobType }, "index_blobs_on_linked_type_linked_id_and_blob_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Blob1)
                    .HasColumnType("blob")
                    .HasColumnName("blob");

                entity.Property(e => e.BlobType)
                    .HasColumnType("integer")
                    .HasColumnName("blob_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LinkedGuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("linked_guid");

                entity.Property(e => e.LinkedId)
                    .HasColumnType("integer")
                    .HasColumnName("linked_id");

                entity.Property(e => e.LinkedType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("linked_type");
            });

            modelBuilder.Entity<CloudsyncFile>(entity =>
            {
                entity.ToTable("cloudsync_files");

                entity.HasIndex(e => new { e.DeviceIdentifier, e.OriginalUrl }, "index_cloudsync_files_on_device_identifier_and_original_url");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("device_identifier");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.NewKey)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("new_key");

                entity.Property(e => e.OriginalUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("original_url");

                entity.Property(e => e.Provider)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("provider");

                entity.Property(e => e.QueryString)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("query_string");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("devices");

                entity.HasIndex(e => e.Identifier, "index_devices_on_identifier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Identifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(e => e.Platform)
                    .HasColumnType("string")
                    .HasColumnName("platform");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Directory>(entity =>
            {
                entity.ToTable("directories");

                entity.HasIndex(e => e.DeletedAt, "index_directories_on_deleted_at");

                entity.HasIndex(e => e.ParentDirectoryId, "index_directories_on_parent_directory_id");

                entity.HasIndex(e => e.Path, "index_directories_on_path");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.ParentDirectoryId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_directory_id");

                entity.Property(e => e.Path)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("path");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<ExternalMetadataItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("external_metadata_items");

                entity.HasIndex(e => e.ExternalMetadataSourceId, "index_external_metadata_items_on_external_source_id");

                entity.HasIndex(e => e.MetadataType, "index_external_metadata_items_on_metadata_type");

                entity.HasIndex(e => e.ParentTitle, "index_external_metadata_items_on_parent_title");

                entity.HasIndex(e => e.Title, "index_external_metadata_items_on_title");

                entity.Property(e => e.AddedAt)
                    .HasColumnType("integer")
                    .HasColumnName("added_at");

                entity.Property(e => e.ExternalMetadataSourceId)
                    .HasColumnType("integer")
                    .HasColumnName("external_metadata_source_id");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.ParentTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parent_title");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("integer")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Year)
                    .HasColumnType("integer")
                    .HasColumnName("year");

                entity.HasOne(d => d.ExternalMetadataSource)
                    .WithMany()
                    .HasForeignKey(d => d.ExternalMetadataSourceId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ExternalMetadataSource>(entity =>
            {
                entity.ToTable("external_metadata_sources");

                entity.HasIndex(e => e.Online, "index_external_metadata_sources_on_online");

                entity.HasIndex(e => e.Uri, "index_external_metadata_sources_on_uri")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Online)
                    .HasColumnType("integer")
                    .HasColumnName("online");

                entity.Property(e => e.SourceTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("source_title");

                entity.Property(e => e.Uri)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uri");

                entity.Property(e => e.UserTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_title");
            });

            modelBuilder.Entity<Fts4MetadataTitlesDocsize>(entity =>
            {
                entity.HasKey(e => e.Docid);

                entity.ToTable("fts4_metadata_titles_docsize");

                entity.Property(e => e.Docid)
                    .ValueGeneratedNever()
                    .HasColumnName("docid");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Fts4MetadataTitlesSegdir>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.Idx });

                entity.ToTable("fts4_metadata_titles_segdir");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndBlock).HasColumnName("end_block");

                entity.Property(e => e.LeavesEndBlock).HasColumnName("leaves_end_block");

                entity.Property(e => e.Root).HasColumnName("root");

                entity.Property(e => e.StartBlock).HasColumnName("start_block");
            });

            modelBuilder.Entity<Fts4MetadataTitlesSegment>(entity =>
            {
                entity.HasKey(e => e.Blockid);

                entity.ToTable("fts4_metadata_titles_segments");

                entity.Property(e => e.Blockid)
                    .ValueGeneratedNever()
                    .HasColumnName("blockid");

                entity.Property(e => e.Block).HasColumnName("block");
            });

            modelBuilder.Entity<Fts4MetadataTitlesStat>(entity =>
            {
                entity.ToTable("fts4_metadata_titles_stat");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Fts4TagTitlesDocsize>(entity =>
            {
                entity.HasKey(e => e.Docid);

                entity.ToTable("fts4_tag_titles_docsize");

                entity.Property(e => e.Docid)
                    .ValueGeneratedNever()
                    .HasColumnName("docid");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Fts4TagTitlesSegdir>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.Idx });

                entity.ToTable("fts4_tag_titles_segdir");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndBlock).HasColumnName("end_block");

                entity.Property(e => e.LeavesEndBlock).HasColumnName("leaves_end_block");

                entity.Property(e => e.Root).HasColumnName("root");

                entity.Property(e => e.StartBlock).HasColumnName("start_block");
            });

            modelBuilder.Entity<Fts4TagTitlesSegment>(entity =>
            {
                entity.HasKey(e => e.Blockid);

                entity.ToTable("fts4_tag_titles_segments");

                entity.Property(e => e.Blockid)
                    .ValueGeneratedNever()
                    .HasColumnName("blockid");

                entity.Property(e => e.Block).HasColumnName("block");
            });

            modelBuilder.Entity<Fts4TagTitlesStat>(entity =>
            {
                entity.ToTable("fts4_tag_titles_stat");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<HubTemplate>(entity =>
            {
                entity.ToTable("hub_templates");

                entity.HasIndex(e => new { e.Section, e.HomeVisibility }, "index_hub_templates_on_section_and_home_visibility");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.HomeVisibility)
                    .HasColumnType("integer")
                    .HasColumnName("home_visibility");

                entity.Property(e => e.Identifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identifier");

                entity.Property(e => e.Order)
                    .HasColumnType("float")
                    .HasColumnName("order");

                entity.Property(e => e.RecommendedVisibility)
                    .HasColumnType("integer")
                    .HasColumnName("recommended_visibility");

                entity.Property(e => e.Section)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("section");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<LibrarySection>(entity =>
            {
                entity.ToTable("library_sections");

                entity.HasIndex(e => e.ChangedAt, "index_library_sections_on_changed_at");

                entity.HasIndex(e => e.Name, "index_library_sections_on_name");

                entity.HasIndex(e => e.NameSort, "index_library_sections_on_name_sort");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Agent)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("agent");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("content_changed_at")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DisplaySecondaryLevel)
                    .HasColumnType("boolean")
                    .HasColumnName("display_secondary_level");

                entity.Property(e => e.Language)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("language");

                entity.Property(e => e.LibraryId)
                    .HasColumnType("integer")
                    .HasColumnName("library_id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(e => e.NameSort)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name_sort");

                entity.Property(e => e.Public)
                    .HasColumnType("boolean")
                    .HasColumnName("public");

                entity.Property(e => e.QueryType)
                    .HasColumnType("integer")
                    .HasColumnName("query_type");

                entity.Property(e => e.QueryXml)
                    .HasColumnType("text")
                    .HasColumnName("query_xml");

                entity.Property(e => e.ScannedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("scanned_at");

                entity.Property(e => e.Scanner)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("scanner");

                entity.Property(e => e.SectionType)
                    .HasColumnType("integer")
                    .HasColumnName("section_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserArtUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_art_url");

                entity.Property(e => e.UserFields)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_fields");

                entity.Property(e => e.UserThemeMusicUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_theme_music_url");

                entity.Property(e => e.UserThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_thumb_url");

                entity.Property(e => e.Uuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<LibrarySectionPermission>(entity =>
            {
                entity.ToTable("library_section_permissions");

                entity.HasIndex(e => e.AccountId, "index_library_section_permissions_on_account_id");

                entity.HasIndex(e => e.LibrarySectionId, "index_library_section_permissions_on_library_section_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.Permission)
                    .HasColumnType("integer")
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<LibraryTimelineEntry>(entity =>
            {
                entity.ToTable("library_timeline_entries");

                entity.HasIndex(e => e.LibrarySectionId, "index_library_timeline_entries_on_library_section_id");

                entity.HasIndex(e => e.MetadataItemId, "index_library_timeline_entries_on_metadata_item_id");

                entity.HasIndex(e => e.State, "index_library_timeline_entries_on_state");

                entity.HasIndex(e => e.UpdatedAt, "index_library_timeline_entries_on_updated_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Locatable>(entity =>
            {
                entity.ToTable("locatables");

                entity.HasIndex(e => new { e.LocationId, e.LocatableId, e.LocatableType }, "IX_locatables_location_id_locatable_id_locatable_type")
                    .IsUnique();

                entity.HasIndex(e => e.GeocodingVersion, "index_locatables_on_geocoding_version");

                entity.HasIndex(e => new { e.LocatableId, e.LocatableType }, "index_locatables_on_locatable_id_and_locatable_type");

                entity.HasIndex(e => new { e.LocationId, e.LocatableId, e.LocatableType }, "index_locatables_on_location_id_and_locatable_id_and_locatable_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("DATETIME")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.GeocodingVersion)
                    .HasColumnType("integer")
                    .HasColumnName("geocoding_version");

                entity.Property(e => e.LocatableId).HasColumnName("locatable_id");

                entity.Property(e => e.LocatableType)
                    .IsRequired()
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("locatable_type");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("DATETIME")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<LocationPlace>(entity =>
            {
                entity.ToTable("location_places");

                entity.HasIndex(e => new { e.LocationId, e.Guid }, "IX_location_places_location_id_guid")
                    .IsUnique();

                entity.HasIndex(e => new { e.LocationId, e.Guid }, "index_location_places_on_location_id_and_guid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("guid");

                entity.Property(e => e.LocationId).HasColumnName("location_id");
            });

            modelBuilder.Entity<LocationsNode>(entity =>
            {
                entity.HasKey(e => e.Nodeno);

                entity.ToTable("locations_node");

                entity.Property(e => e.Nodeno)
                    .ValueGeneratedNever()
                    .HasColumnName("nodeno");

                entity.Property(e => e.Data).HasColumnName("data");
            });

            modelBuilder.Entity<LocationsParent>(entity =>
            {
                entity.HasKey(e => e.Nodeno);

                entity.ToTable("locations_parent");

                entity.Property(e => e.Nodeno)
                    .ValueGeneratedNever()
                    .HasColumnName("nodeno");

                entity.Property(e => e.Parentnode).HasColumnName("parentnode");
            });

            modelBuilder.Entity<LocationsRowid>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("locations_rowid");

                entity.Property(e => e.Rowid)
                    .ValueGeneratedNever()
                    .HasColumnName("rowid");

                entity.Property(e => e.Nodeno).HasColumnName("nodeno");
            });

            modelBuilder.Entity<MediaGrab>(entity =>
            {
                entity.ToTable("media_grabs");

                entity.HasIndex(e => e.CreatedAt, "media_grabs_on_created_at");

                entity.HasIndex(e => e.MetadataItemId, "media_grabs_on_metadata_item_id");

                entity.HasIndex(e => e.Uuid, "media_grabs_on_uuid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Error)
                    .HasColumnType("integer")
                    .HasColumnName("error");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.MediaSubscriptionId)
                    .HasColumnType("integer")
                    .HasColumnName("media_subscription_id");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.Status)
                    .HasColumnType("integer")
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Uuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<MediaItem>(entity =>
            {
                entity.ToTable("media_items");

                entity.HasIndex(e => e.BeginsAt, "index_media_items_on_begins_at");

                entity.HasIndex(e => e.ChannelId, "index_media_items_on_channel_id");

                entity.HasIndex(e => new { e.ChannelId, e.BeginsAt }, "index_media_items_on_channel_id_and_begins_at");

                entity.HasIndex(e => e.DeletedAt, "index_media_items_on_deleted_at");

                entity.HasIndex(e => e.EndsAt, "index_media_items_on_ends_at");

                entity.HasIndex(e => e.LibrarySectionId, "index_media_items_on_library_section_id");

                entity.HasIndex(e => e.MediaAnalysisVersion, "index_media_items_on_media_analysis_version");

                entity.HasIndex(e => e.MetadataItemId, "index_media_items_on_metadata_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AudioChannels)
                    .HasColumnType("integer")
                    .HasColumnName("audio_channels");

                entity.Property(e => e.AudioCodec)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("audio_codec");

                entity.Property(e => e.BeginsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("begins_at");

                entity.Property(e => e.Bitrate)
                    .HasColumnType("integer")
                    .HasColumnName("bitrate");

                entity.Property(e => e.ChannelId)
                    .HasColumnType("integer")
                    .HasColumnName("channel_id");

                entity.Property(e => e.ColorTrc)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("color_trc");

                entity.Property(e => e.Container)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("container");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DisplayAspectRatio)
                    .HasColumnType("float")
                    .HasColumnName("display_aspect_ratio");

                entity.Property(e => e.DisplayOffset)
                    .HasColumnType("integer")
                    .HasColumnName("display_offset");

                entity.Property(e => e.Duration)
                    .HasColumnType("integer")
                    .HasColumnName("duration");

                entity.Property(e => e.EndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("ends_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.FramesPerSecond)
                    .HasColumnType("float")
                    .HasColumnName("frames_per_second");

                entity.Property(e => e.Height)
                    .HasColumnType("integer")
                    .HasColumnName("height");

                entity.Property(e => e.Hints)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hints");

                entity.Property(e => e.Interlaced)
                    .HasColumnType("boolean")
                    .HasColumnName("interlaced");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MediaAnalysisVersion)
                    .HasColumnType("integer")
                    .HasColumnName("media_analysis_version")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.OptimizedForStreaming)
                    .HasColumnType("boolean")
                    .HasColumnName("optimized_for_streaming");

                entity.Property(e => e.ProxyType)
                    .HasColumnType("integer")
                    .HasColumnName("proxy_type");

                entity.Property(e => e.SampleAspectRatio)
                    .HasColumnType("float")
                    .HasColumnName("sample_aspect_ratio");

                entity.Property(e => e.SectionLocationId)
                    .HasColumnType("integer")
                    .HasColumnName("section_location_id");

                entity.Property(e => e.Settings)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("settings");

                entity.Property(e => e.Size)
                    .HasColumnType("integer(8)")
                    .HasColumnName("size");

                entity.Property(e => e.Source)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("source");

                entity.Property(e => e.TypeId)
                    .HasColumnType("integer")
                    .HasColumnName("type_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.VideoCodec)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("video_codec");

                entity.Property(e => e.Width)
                    .HasColumnType("integer")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<MediaItemSetting>(entity =>
            {
                entity.ToTable("media_item_settings");

                entity.HasIndex(e => e.AccountId, "index_media_item_settings_on_account_id");

                entity.HasIndex(e => e.MediaItemId, "index_media_item_settings_on_media_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.MediaItemId)
                    .HasColumnType("integer")
                    .HasColumnName("media_item_id");

                entity.Property(e => e.Settings)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("settings");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MediaMetadataMapping>(entity =>
            {
                entity.ToTable("media_metadata_mappings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.MediaGuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_guid");

                entity.Property(e => e.MetadataGuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("metadata_guid");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MediaPart>(entity =>
            {
                entity.ToTable("media_parts");

                entity.HasIndex(e => e.DeletedAt, "index_media_parts_on_deleted_at");

                entity.HasIndex(e => e.DirectoryId, "index_media_parts_on_directory_id");

                entity.HasIndex(e => e.File, "index_media_parts_on_file");

                entity.HasIndex(e => e.Hash, "index_media_parts_on_hash");

                entity.HasIndex(e => e.MediaItemId, "index_media_parts_on_media_item_id");

                entity.HasIndex(e => e.Size, "index_media_parts_on_size");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.DirectoryId)
                    .HasColumnType("integer")
                    .HasColumnName("directory_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("integer")
                    .HasColumnName("duration");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.File)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("file");

                entity.Property(e => e.Hash)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hash");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.MediaItemId)
                    .HasColumnType("integer")
                    .HasColumnName("media_item_id");

                entity.Property(e => e.OpenSubtitleHash)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("open_subtitle_hash");

                entity.Property(e => e.Size)
                    .HasColumnType("integer(8)")
                    .HasColumnName("size");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MediaPartSetting>(entity =>
            {
                entity.ToTable("media_part_settings");

                entity.HasIndex(e => e.AccountId, "index_media_part_settings_on_account_id");

                entity.HasIndex(e => e.ChangedAt, "index_media_part_settings_on_changed_at");

                entity.HasIndex(e => e.MediaPartId, "index_media_part_settings_on_media_part_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.MediaPartId)
                    .HasColumnType("integer")
                    .HasColumnName("media_part_id");

                entity.Property(e => e.SelectedAudioStreamId)
                    .HasColumnType("integer")
                    .HasColumnName("selected_audio_stream_id");

                entity.Property(e => e.SelectedSubtitleStreamId)
                    .HasColumnType("integer")
                    .HasColumnName("selected_subtitle_stream_id");

                entity.Property(e => e.Settings)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("settings");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MediaProviderResource>(entity =>
            {
                entity.ToTable("media_provider_resources");

                entity.HasIndex(e => e.Identifier, "media_provider_resources_on_identifier");

                entity.HasIndex(e => e.ParentId, "media_provider_resources_on_parent_id");

                entity.HasIndex(e => e.Type, "media_provider_resources_on_type");

                entity.HasIndex(e => e.Uuid, "media_provider_resources_on_uuid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Data)
                    .HasColumnType("blob")
                    .HasColumnName("data");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Identifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identifier");

                entity.Property(e => e.LastSeenAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_seen_at");

                entity.Property(e => e.ParentId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Protocol)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("protocol");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasColumnType("integer")
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasColumnType("integer")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Uri)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uri");

                entity.Property(e => e.Uuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uuid");
            });

            modelBuilder.Entity<MediaStream>(entity =>
            {
                entity.ToTable("media_streams");

                entity.HasIndex(e => e.Language, "index_media_streams_on_language");

                entity.HasIndex(e => e.MediaItemId, "index_media_streams_on_media_item_id");

                entity.HasIndex(e => e.MediaPartId, "index_media_streams_on_media_part_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bitrate)
                    .HasColumnType("integer")
                    .HasColumnName("bitrate");

                entity.Property(e => e.Channels)
                    .HasColumnType("integer")
                    .HasColumnName("channels");

                entity.Property(e => e.Codec)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("codec");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Default)
                    .HasColumnType("boolean")
                    .HasColumnName("default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Forced)
                    .HasColumnType("boolean")
                    .HasColumnName("forced")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.Language)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("language");

                entity.Property(e => e.MediaItemId)
                    .HasColumnType("integer")
                    .HasColumnName("media_item_id");

                entity.Property(e => e.MediaPartId)
                    .HasColumnType("integer")
                    .HasColumnName("media_part_id");

                entity.Property(e => e.StreamTypeId)
                    .HasColumnType("integer")
                    .HasColumnName("stream_type_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("url");

                entity.Property(e => e.UrlIndex)
                    .HasColumnType("integer")
                    .HasColumnName("url_index");
            });

            modelBuilder.Entity<MediaStreamSetting>(entity =>
            {
                entity.ToTable("media_stream_settings");

                entity.HasIndex(e => new { e.MediaStreamId, e.AccountId }, "IX_media_stream_settings_media_stream_id_account_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.MediaStreamId, e.AccountId }, "index_media_stream_settings_on_media_stream_id_and_account_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.MediaStreamId).HasColumnName("media_stream_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MediaSubscription>(entity =>
            {
                entity.ToTable("media_subscriptions");

                entity.HasIndex(e => e.Order, "media_subscriptions_on_order");

                entity.HasIndex(e => e.TargetMetadataItemId, "media_subscriptions_on_target_metadata_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.Order)
                    .HasColumnType("float")
                    .HasColumnName("order");

                entity.Property(e => e.TargetLibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("target_library_section_id");

                entity.Property(e => e.TargetMetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("target_metadata_item_id");

                entity.Property(e => e.TargetSectionLocationId)
                    .HasColumnType("integer")
                    .HasColumnName("target_section_location_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MetadataItem>(entity =>
            {
                entity.ToTable("metadata_items");

                entity.HasIndex(e => e.AbsoluteIndex, "index_metadata_items_on_absolute_index");

                entity.HasIndex(e => e.AddedAt, "index_metadata_items_on_added_at");

                entity.HasIndex(e => e.ChangedAt, "index_metadata_items_on_changed_at");

                entity.HasIndex(e => e.CreatedAt, "index_metadata_items_on_created_at");

                entity.HasIndex(e => e.DeletedAt, "index_metadata_items_on_deleted_at");

                entity.HasIndex(e => e.Guid, "index_metadata_items_on_guid");

                entity.HasIndex(e => e.Hash, "index_metadata_items_on_hash");

                entity.HasIndex(e => e.Index, "index_metadata_items_on_index");

                entity.HasIndex(e => e.LibrarySectionId, "index_metadata_items_on_library_section_id");

                entity.HasIndex(e => new { e.LibrarySectionId, e.MetadataType, e.AddedAt }, "index_metadata_items_on_library_section_id_and_metadata_type_and_added_at");

                entity.HasIndex(e => e.MetadataType, "index_metadata_items_on_metadata_type");

                entity.HasIndex(e => e.OriginalTitle, "index_metadata_items_on_original_title");

                entity.HasIndex(e => e.OriginallyAvailableAt, "index_metadata_items_on_originally_available_at");

                entity.HasIndex(e => e.ParentId, "index_metadata_items_on_parent_id");

                entity.HasIndex(e => e.Remote, "index_metadata_items_on_remote");

                entity.HasIndex(e => e.ResourcesChangedAt, "index_metadata_items_on_resources_changed_at");

                entity.HasIndex(e => e.Title, "index_metadata_items_on_title");

                entity.HasIndex(e => e.TitleSort, "index_metadata_items_on_title_sort");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbsoluteIndex)
                    .HasColumnType("integer")
                    .HasColumnName("absolute_index");

                entity.Property(e => e.AddedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("added_at");

                entity.Property(e => e.AudienceRating)
                    .HasColumnType("float")
                    .HasColumnName("audience_rating");

                entity.Property(e => e.AvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("available_at");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContentRating)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("content_rating");

                entity.Property(e => e.ContentRatingAge)
                    .HasColumnType("integer")
                    .HasColumnName("content_rating_age");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Duration)
                    .HasColumnType("integer")
                    .HasColumnName("duration");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expires_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guid");

                entity.Property(e => e.Hash)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hash");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MediaItemCount)
                    .HasColumnType("integer")
                    .HasColumnName("media_item_count");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.OriginalTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("original_title");

                entity.Property(e => e.OriginallyAvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("originally_available_at");

                entity.Property(e => e.ParentId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Quotes)
                    .HasColumnType("text")
                    .HasColumnName("quotes");

                entity.Property(e => e.Rating)
                    .HasColumnType("float")
                    .HasColumnName("rating");

                entity.Property(e => e.RatingCount)
                    .HasColumnType("integer")
                    .HasColumnName("rating_count");

                entity.Property(e => e.RefreshedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("refreshed_at");

                entity.Property(e => e.Remote)
                    .HasColumnType("integer")
                    .HasColumnName("remote");

                entity.Property(e => e.ResourcesChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("resources_changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Studio)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("studio");

                entity.Property(e => e.Summary)
                    .HasColumnType("text")
                    .HasColumnName("summary");

                entity.Property(e => e.Tagline)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tagline");

                entity.Property(e => e.TagsCollection)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_collection");

                entity.Property(e => e.TagsCountry)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_country");

                entity.Property(e => e.TagsDirector)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_director");

                entity.Property(e => e.TagsGenre)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_genre");

                entity.Property(e => e.TagsStar)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_star");

                entity.Property(e => e.TagsWriter)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags_writer");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");

                entity.Property(e => e.TitleSort)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title_sort");

                entity.Property(e => e.Trivia)
                    .HasColumnType("text")
                    .HasColumnName("trivia");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserArtUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_art_url");

                entity.Property(e => e.UserBannerUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_banner_url");

                entity.Property(e => e.UserFields)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_fields");

                entity.Property(e => e.UserMusicUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_music_url");

                entity.Property(e => e.UserThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_thumb_url");

                entity.Property(e => e.Year)
                    .HasColumnType("integer")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<MetadataItemAccount>(entity =>
            {
                entity.ToTable("metadata_item_accounts");

                entity.HasIndex(e => e.AccountId, "index_metadata_item_accounts_on_account_id");

                entity.HasIndex(e => e.MetadataItemId, "index_metadata_item_accounts_on_metadata_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");
            });

            modelBuilder.Entity<MetadataItemCluster>(entity =>
            {
                entity.ToTable("metadata_item_clusters");

                entity.HasIndex(e => e.LibrarySectionId, "index_metadata_item_clusters_on_library_section_id");

                entity.HasIndex(e => e.Title, "index_metadata_item_clusters_on_title");

                entity.HasIndex(e => e.ZoomLevel, "index_metadata_item_clusters_on_zoom_level");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("integer")
                    .HasColumnName("count");

                entity.Property(e => e.EndsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("ends_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.StartsAt)
                    .HasColumnType("datetime")
                    .HasColumnName("starts_at");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");

                entity.Property(e => e.ZoomLevel)
                    .HasColumnType("integer")
                    .HasColumnName("zoom_level");
            });

            modelBuilder.Entity<MetadataItemClustering>(entity =>
            {
                entity.ToTable("metadata_item_clusterings");

                entity.HasIndex(e => e.MetadataItemClusterId, "index_metadata_item_clusterings_on_metadata_item_cluster_id");

                entity.HasIndex(e => e.MetadataItemId, "index_metadata_item_clusterings_on_metadata_item_id");

                entity.HasIndex(e => e.Version, "index_metadata_item_clusterings_on_version");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.MetadataItemClusterId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_cluster_id");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.Version)
                    .HasColumnType("integer")
                    .HasColumnName("version");

                entity.HasOne(d => d.MetadataItemCluster)
                    .WithMany(p => p.MetadataItemClusterings)
                    .HasForeignKey(d => d.MetadataItemClusterId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.MetadataItem)
                    .WithMany(p => p.MetadataItemClusterings)
                    .HasForeignKey(d => d.MetadataItemId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<MetadataItemSetting>(entity =>
            {
                entity.ToTable("metadata_item_settings");

                entity.HasIndex(e => e.AccountId, "index_metadata_item_settings_on_account_id");

                entity.HasIndex(e => e.ChangedAt, "index_metadata_item_settings_on_changed_at");

                entity.HasIndex(e => e.Guid, "index_metadata_item_settings_on_guid");

                entity.HasIndex(e => e.LastViewedAt, "index_metadata_item_settings_on_last_viewed_at");

                entity.HasIndex(e => e.Rating, "index_metadata_item_settings_on_rating");

                entity.HasIndex(e => e.SkipCount, "index_metadata_item_settings_on_skip_count");

                entity.HasIndex(e => e.ViewCount, "index_metadata_item_settings_on_view_count");

                entity.HasIndex(e => e.ViewOffset, "index_metadata_item_settings_on_view_offset");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guid");

                entity.Property(e => e.LastRatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_rated_at");

                entity.Property(e => e.LastSkippedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_skipped_at");

                entity.Property(e => e.LastViewedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_viewed_at");

                entity.Property(e => e.Rating)
                    .HasColumnType("float")
                    .HasColumnName("rating");

                entity.Property(e => e.SkipCount)
                    .HasColumnType("integer")
                    .HasColumnName("skip_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.ViewCount)
                    .HasColumnType("integer")
                    .HasColumnName("view_count");

                entity.Property(e => e.ViewOffset)
                    .HasColumnType("integer")
                    .HasColumnName("view_offset");
            });

            modelBuilder.Entity<MetadataItemView>(entity =>
            {
                entity.ToTable("metadata_item_views");

                entity.HasIndex(e => e.GrandparentGuid, "index_metadata_item_views_on_grandparent_guid");

                entity.HasIndex(e => e.Guid, "index_metadata_item_views_on_guid");

                entity.HasIndex(e => e.LibrarySectionId, "index_metadata_item_views_on_library_section_id");

                entity.HasIndex(e => e.ViewedAt, "index_metadata_item_views_on_viewed_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("integer")
                    .HasColumnName("device_id");

                entity.Property(e => e.GrandparentGuid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("grandparent_guid");

                entity.Property(e => e.GrandparentTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("grandparent_title");

                entity.Property(e => e.Guid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guid");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.OriginallyAvailableAt)
                    .HasColumnType("datetime")
                    .HasColumnName("originally_available_at");

                entity.Property(e => e.ParentIndex)
                    .HasColumnType("integer")
                    .HasColumnName("parent_index");

                entity.Property(e => e.ParentTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parent_title");

                entity.Property(e => e.ThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb_url");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");

                entity.Property(e => e.ViewedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("viewed_at");
            });

            modelBuilder.Entity<MetadataRelation>(entity =>
            {
                entity.ToTable("metadata_relations");

                entity.HasIndex(e => e.MetadataItemId, "index_metadata_relations_on_metadata_item_id");

                entity.HasIndex(e => e.RelatedMetadataItemId, "index_metadata_relations_on_related_metadata_item_id");

                entity.HasIndex(e => e.RelationType, "index_metadata_relations_on_relation_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.RelatedMetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("related_metadata_item_id");

                entity.Property(e => e.RelationType)
                    .HasColumnType("integer")
                    .HasColumnName("relation_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MetadataSubscriptionDesiredItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("metadata_subscription_desired_items");

                entity.HasIndex(e => e.RemoteId, "index_metadata_subscription_desired_items_on_remote_id");

                entity.HasIndex(e => e.SubId, "index_metadata_subscription_desired_items_on_sub_id");

                entity.Property(e => e.RemoteId)
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("remote_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");
            });

            modelBuilder.Entity<PlayQueue>(entity =>
            {
                entity.ToTable("play_queues");

                entity.HasIndex(e => e.AccountId, "index_play_queues_on_account_id");

                entity.HasIndex(e => new { e.ClientIdentifier, e.AccountId, e.MetadataType }, "index_play_queues_on_client_identifier_and_account_id_and_metadata_type")
                    .IsUnique();

                entity.HasIndex(e => e.PlaylistId, "index_play_queues_on_playlist_id");

                entity.HasIndex(e => e.SyncItemId, "index_play_queues_on_sync_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("client_identifier");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CurrentPlayQueueItemId)
                    .HasColumnType("integer")
                    .HasColumnName("current_play_queue_item_id");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.GeneratorEndIndex)
                    .HasColumnType("integer")
                    .HasColumnName("generator_end_index");

                entity.Property(e => e.GeneratorGeneratorIds)
                    .HasColumnType("blob")
                    .HasColumnName("generator_generator_ids");

                entity.Property(e => e.GeneratorIds)
                    .HasColumnType("blob")
                    .HasColumnName("generator_ids");

                entity.Property(e => e.GeneratorItemsCount)
                    .HasColumnType("integer")
                    .HasColumnName("generator_items_count");

                entity.Property(e => e.GeneratorStartIndex)
                    .HasColumnType("integer")
                    .HasColumnName("generator_start_index");

                entity.Property(e => e.LastAddedPlayQueueItemId)
                    .HasColumnType("integer")
                    .HasColumnName("last_added_play_queue_item_id");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.PlayQueueGeneratorId)
                    .HasColumnType("integer")
                    .HasColumnName("play_queue_generator_id");

                entity.Property(e => e.PlaylistId)
                    .HasColumnType("integer")
                    .HasColumnName("playlist_id");

                entity.Property(e => e.Seed)
                    .HasColumnType("integer")
                    .HasColumnName("seed");

                entity.Property(e => e.SyncItemId)
                    .HasColumnType("integer")
                    .HasColumnName("sync_item_id");

                entity.Property(e => e.TotalItemsCount)
                    .HasColumnType("integer")
                    .HasColumnName("total_items_count");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Version)
                    .HasColumnType("integer")
                    .HasColumnName("version");
            });

            modelBuilder.Entity<PlayQueueGenerator>(entity =>
            {
                entity.ToTable("play_queue_generators");

                entity.HasIndex(e => e.ChangedAt, "index_play_queue_generators_on_changed_at");

                entity.HasIndex(e => e.MetadataItemId, "index_play_queue_generators_on_metadata_item_id");

                entity.HasIndex(e => e.Order, "index_play_queue_generators_on_order");

                entity.HasIndex(e => e.PlaylistId, "index_play_queue_generators_on_playlist_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Continuous)
                    .HasColumnType("boolean")
                    .HasColumnName("continuous");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Limit)
                    .HasColumnType("integer")
                    .HasColumnName("limit");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.Order)
                    .HasColumnType("float")
                    .HasColumnName("order");

                entity.Property(e => e.PlaylistId)
                    .HasColumnType("integer")
                    .HasColumnName("playlist_id");

                entity.Property(e => e.Recursive)
                    .HasColumnType("boolean")
                    .HasColumnName("recursive");

                entity.Property(e => e.Type)
                    .HasColumnType("integer")
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Uri)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uri");
            });

            modelBuilder.Entity<PlayQueueItem>(entity =>
            {
                entity.ToTable("play_queue_items");

                entity.HasIndex(e => e.MetadataItemId, "index_play_queue_items_on_metadata_item_id");

                entity.HasIndex(e => e.Order, "index_play_queue_items_on_order");

                entity.HasIndex(e => e.PlayQueueId, "index_play_queue_items_on_play_queue_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.Order)
                    .HasColumnType("float")
                    .HasColumnName("order");

                entity.Property(e => e.PlayQueueGeneratorId)
                    .HasColumnType("integer")
                    .HasColumnName("play_queue_generator_id");

                entity.Property(e => e.PlayQueueId)
                    .HasColumnType("integer")
                    .HasColumnName("play_queue_id");

                entity.Property(e => e.UpNext)
                    .HasColumnType("boolean")
                    .HasColumnName("up_next");
            });

            modelBuilder.Entity<Plugin>(entity =>
            {
                entity.ToTable("plugins");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessCount)
                    .HasColumnType("integer")
                    .HasColumnName("access_count");

                entity.Property(e => e.AccessedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("accessed_at");

                entity.Property(e => e.FrameworkVersion)
                    .HasColumnType("integer")
                    .HasColumnName("framework_version");

                entity.Property(e => e.Identifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("identifier");

                entity.Property(e => e.InstalledAt)
                    .HasColumnType("datetime")
                    .HasColumnName("installed_at");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_at");
            });

            modelBuilder.Entity<PluginPermission>(entity =>
            {
                entity.ToTable("plugin_permissions");

                entity.HasIndex(e => e.AccountId, "index_plugin_permissions_on_account_id");

                entity.HasIndex(e => e.PluginId, "index_plugin_permissions_on_plugin_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.Permission)
                    .HasColumnType("integer")
                    .HasColumnName("permission");

                entity.Property(e => e.PluginId)
                    .HasColumnType("integer")
                    .HasColumnName("plugin_id");
            });

            modelBuilder.Entity<PluginPrefix>(entity =>
            {
                entity.ToTable("plugin_prefixes");

                entity.HasIndex(e => e.PluginId, "index_plugin_prefixes_on_plugin_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("art_url");

                entity.Property(e => e.HasStoreServices)
                    .HasColumnType("boolean")
                    .HasColumnName("has_store_services");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(e => e.PluginId)
                    .HasColumnType("integer")
                    .HasColumnName("plugin_id");

                entity.Property(e => e.Prefix)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("prefix");

                entity.Property(e => e.Prefs)
                    .HasColumnType("boolean")
                    .HasColumnName("prefs");

                entity.Property(e => e.Share)
                    .HasColumnType("boolean")
                    .HasColumnName("share");

                entity.Property(e => e.ThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb_url");

                entity.Property(e => e.TitlebarUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("titlebar_url");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.ToTable("preferences");

                entity.HasIndex(e => e.Name, "index_preferences_on_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<RemoteIdTranslation>(entity =>
            {
                entity.ToTable("remote_id_translation");

                entity.HasIndex(e => e.LocalId, "remote_id_translation_on_local_id");

                entity.HasIndex(e => e.RemoteId, "remote_id_translation_on_remote_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LocalId).HasColumnName("local_id");

                entity.Property(e => e.RemoteId)
                    .HasColumnType("VARCHAR(255)")
                    .HasColumnName("remote_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SchemaMigration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("schema_migrations");

                entity.HasIndex(e => e.Version, "unique_schema_migrations")
                    .IsUnique();

                entity.Property(e => e.OptimizeOnRollback)
                    .HasColumnType("boolean")
                    .HasColumnName("optimize_on_rollback");

                entity.Property(e => e.RollbackSql)
                    .HasColumnType("text")
                    .HasColumnName("rollback_sql");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("version");
            });

            modelBuilder.Entity<SectionLocation>(entity =>
            {
                entity.ToTable("section_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available)
                    .HasColumnType("boolean")
                    .HasColumnName("available")
                    .HasDefaultValueSql("'t'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.RootPath)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("root_path");

                entity.Property(e => e.ScannedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("scanned_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<SpellfixMetadataTitlesVocab>(entity =>
            {
                entity.ToTable("spellfix_metadata_titles_vocab");

                entity.HasIndex(e => new { e.Langid, e.K2 }, "spellfix_metadata_titles_vocab_index_langid_k2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.Langid)
                    .HasColumnType("INT")
                    .HasColumnName("langid");

                entity.Property(e => e.Rank)
                    .HasColumnType("INT")
                    .HasColumnName("rank");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<SpellfixTagTitlesVocab>(entity =>
            {
                entity.ToTable("spellfix_tag_titles_vocab");

                entity.HasIndex(e => new { e.Langid, e.K2 }, "spellfix_tag_titles_vocab_index_langid_k2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.K1).HasColumnName("k1");

                entity.Property(e => e.K2).HasColumnName("k2");

                entity.Property(e => e.Langid)
                    .HasColumnType("INT")
                    .HasColumnName("langid");

                entity.Property(e => e.Rank)
                    .HasColumnType("INT")
                    .HasColumnName("rank");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<StatisticsBandwidth>(entity =>
            {
                entity.ToTable("statistics_bandwidth");

                entity.HasIndex(e => new { e.AccountId, e.Timespan, e.At }, "index_statistics_bandwidth_on_account_id_and_timespan_and_at");

                entity.HasIndex(e => e.At, "index_statistics_bandwidth_on_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Bytes)
                    .HasColumnType("integer(8)")
                    .HasColumnName("bytes");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("integer")
                    .HasColumnName("device_id");

                entity.Property(e => e.Lan)
                    .HasColumnType("boolean")
                    .HasColumnName("lan");

                entity.Property(e => e.Timespan)
                    .HasColumnType("integer")
                    .HasColumnName("timespan");
            });

            modelBuilder.Entity<StatisticsMedium>(entity =>
            {
                entity.ToTable("statistics_media");

                entity.HasIndex(e => new { e.AccountId, e.Timespan, e.At }, "index_statistics_media_on_account_id_and_timespan_and_at");

                entity.HasIndex(e => e.At, "index_statistics_media_on_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.Count)
                    .HasColumnType("integer")
                    .HasColumnName("count");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("integer")
                    .HasColumnName("device_id");

                entity.Property(e => e.Duration)
                    .HasColumnType("integer")
                    .HasColumnName("duration");

                entity.Property(e => e.MetadataType)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_type");

                entity.Property(e => e.Timespan)
                    .HasColumnType("integer")
                    .HasColumnName("timespan");
            });

            modelBuilder.Entity<StatisticsResource>(entity =>
            {
                entity.ToTable("statistics_resources");

                entity.HasIndex(e => e.At, "index_statistics_resources_on_at");

                entity.HasIndex(e => e.Timespan, "index_statistics_resources_on_timespan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.At)
                    .HasColumnType("datetime")
                    .HasColumnName("at");

                entity.Property(e => e.HostCpuUtilization)
                    .HasColumnType("float")
                    .HasColumnName("host_cpu_utilization");

                entity.Property(e => e.HostMemoryUtilization)
                    .HasColumnType("float")
                    .HasColumnName("host_memory_utilization");

                entity.Property(e => e.ProcessCpuUtilization)
                    .HasColumnType("float")
                    .HasColumnName("process_cpu_utilization");

                entity.Property(e => e.ProcessMemoryUtilization)
                    .HasColumnType("float")
                    .HasColumnName("process_memory_utilization");

                entity.Property(e => e.Timespan)
                    .HasColumnType("integer")
                    .HasColumnName("timespan");
            });

            modelBuilder.Entity<StreamType>(entity =>
            {
                entity.ToTable("stream_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SyncSchemaVersion>(entity =>
            {
                entity.ToTable("sync_schema_versions");

                entity.HasIndex(e => e.ChangedAt, "index_sync_schema_versions_on_changed_at");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at");

                entity.Property(e => e.Version)
                    .HasColumnType("integer")
                    .HasColumnName("version");
            });

            modelBuilder.Entity<SyncedAncestorItem>(entity =>
            {
                entity.ToTable("synced_ancestor_items");

                entity.HasIndex(e => e.ChangedAt, "index_synced_ancestor_items_on_changed_at");

                entity.HasIndex(e => e.MetadataItemId, "index_synced_ancestor_items_on_metadata_item_id");

                entity.HasIndex(e => e.ReferenceCount, "index_synced_ancestor_items_on_reference_count");

                entity.HasIndex(e => e.SyncListId, "index_synced_ancestor_items_on_sync_list_id");

                entity.HasIndex(e => new { e.SyncListId, e.MetadataItemId }, "index_synced_ancestor_items_on_sync_list_id_and_metadata_item_id")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId, "index_synced_ancestor_items_parent_id");

                entity.HasIndex(e => e.State, "index_synced_ancestor_items_state");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at");

                entity.Property(e => e.FirstPackagedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("first_packaged_at");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.ParentId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_id");

                entity.Property(e => e.ReferenceCount)
                    .HasColumnType("integer")
                    .HasColumnName("reference_count");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.SyncListId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_list_id");
            });

            modelBuilder.Entity<SyncedLibrarySection>(entity =>
            {
                entity.ToTable("synced_library_sections");

                entity.HasIndex(e => e.ChangedAt, "index_synced_library_sections_on_changed_at");

                entity.HasIndex(e => e.LibrarySectionId, "index_synced_library_sections_on_library_section_id");

                entity.HasIndex(e => e.ReferenceCount, "index_synced_library_sections_on_reference_count");

                entity.HasIndex(e => e.SyncListId, "index_synced_library_sections_on_sync_list_id");

                entity.HasIndex(e => new { e.SyncListId, e.LibrarySectionId }, "index_synced_library_sections_on_sync_list_id_and_library_section_id")
                    .IsUnique();

                entity.HasIndex(e => e.State, "index_synced_library_sections_state");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at");

                entity.Property(e => e.FirstPackagedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("first_packaged_at");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.ReferenceCount)
                    .HasColumnType("integer")
                    .HasColumnName("reference_count");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.SyncListId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_list_id");
            });

            modelBuilder.Entity<SyncedMetadataItem>(entity =>
            {
                entity.ToTable("synced_metadata_items");

                entity.HasIndex(e => e.LibrarySectionId, "index_synced_metadata_items_library_section_id");

                entity.HasIndex(e => e.ChangedAt, "index_synced_metadata_items_on_changed_at");

                entity.HasIndex(e => e.FirstPackagedAt, "index_synced_metadata_items_on_first_packaged_at");

                entity.HasIndex(e => e.MetadataItemId, "index_synced_metadata_items_on_metadata_item_id");

                entity.HasIndex(e => e.State, "index_synced_metadata_items_on_state");

                entity.HasIndex(e => e.SyncItemId, "index_synced_metadata_items_on_sync_item_id");

                entity.HasIndex(e => e.SyncListId, "index_synced_metadata_items_on_sync_list_id");

                entity.HasIndex(e => new { e.SyncListId, e.MetadataItemId }, "index_synced_metadata_items_on_sync_list_id_and_metadata_item_id")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId, "index_synced_metadata_items_parent_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at");

                entity.Property(e => e.FileSize)
                    .HasColumnType("integer(8)")
                    .HasColumnName("file_size");

                entity.Property(e => e.FirstPackagedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("first_packaged_at");

                entity.Property(e => e.LibrarySectionId)
                    .HasColumnType("integer")
                    .HasColumnName("library_section_id");

                entity.Property(e => e.MediaAnalysisExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_analysis_extra_data");

                entity.Property(e => e.MediaDecision)
                    .HasColumnType("integer")
                    .HasColumnName("media_decision");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.ParentId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_id");

                entity.Property(e => e.SelectedMediaId)
                    .HasColumnType("integer")
                    .HasColumnName("selected_media_id");

                entity.Property(e => e.SelectedPartId)
                    .HasColumnType("integer")
                    .HasColumnName("selected_part_id");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.StateContext)
                    .HasColumnType("integer")
                    .HasColumnName("state_context");

                entity.Property(e => e.SyncItemId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_item_id");

                entity.Property(e => e.SyncListId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_list_id");
            });

            modelBuilder.Entity<SyncedPlayQueueGenerator>(entity =>
            {
                entity.ToTable("synced_play_queue_generators");

                entity.HasIndex(e => e.ChangedAt, "index_synced_play_queue_generators_on_changed_at");

                entity.HasIndex(e => e.PlayQueueGeneratorId, "index_synced_play_queue_generators_on_play_queue_generator_id");

                entity.HasIndex(e => e.PlaylistId, "index_synced_play_queue_generators_on_playlist_id");

                entity.HasIndex(e => e.State, "index_synced_play_queue_generators_on_state");

                entity.HasIndex(e => e.SyncItemId, "index_synced_play_queue_generators_on_sync_item_id");

                entity.HasIndex(e => e.SyncListId, "index_synced_play_queue_generators_on_sync_list_id");

                entity.HasIndex(e => new { e.SyncListId, e.PlayQueueGeneratorId }, "index_synced_play_queue_generators_on_sync_list_id_and_play_queue_generator_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("changed_at");

                entity.Property(e => e.FirstPackagedAt)
                    .HasColumnType("integer(8)")
                    .HasColumnName("first_packaged_at");

                entity.Property(e => e.PlayQueueGeneratorId)
                    .HasColumnType("integer")
                    .HasColumnName("play_queue_generator_id");

                entity.Property(e => e.PlaylistId)
                    .HasColumnType("integer")
                    .HasColumnName("playlist_id");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.StateContext)
                    .HasColumnType("integer")
                    .HasColumnName("state_context");

                entity.Property(e => e.SyncItemId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_item_id");

                entity.Property(e => e.SyncListId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_list_id");
            });

            modelBuilder.Entity<SynchronizationFile>(entity =>
            {
                entity.ToTable("synchronization_files");

                entity.HasIndex(e => e.ClientIdentifier, "index_synchronization_files_on_client_identifier");

                entity.HasIndex(e => e.ItemUri, "index_synchronization_files_on_item_uri");

                entity.HasIndex(e => e.SyncItemId, "index_synchronization_files_on_sync_item_id");

                entity.HasIndex(e => e.SyncListId, "index_synchronization_files_on_sync_list_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("client_identifier");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.ItemUri)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("item_uri");

                entity.Property(e => e.NumParts)
                    .HasColumnType("integer")
                    .HasColumnName("num_parts");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.StateContext)
                    .HasColumnType("integer")
                    .HasColumnName("state_context");

                entity.Property(e => e.SyncItemId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_item_id");

                entity.Property(e => e.SyncListId)
                    .HasColumnType("integer(8)")
                    .HasColumnName("sync_list_id");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tags");

                entity.HasIndex(e => e.Key, "index_tags_on_key");

                entity.HasIndex(e => e.ParentId, "index_tags_on_parent_id");

                entity.HasIndex(e => e.Tag1, "index_tags_on_tag");

                entity.HasIndex(e => e.TagType, "index_tags_on_tag_type");

                entity.HasIndex(e => new { e.TagType, e.Tag1 }, "index_tags_on_tag_type_and_tag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Key)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("key");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.ParentId)
                    .HasColumnType("integer")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Tag1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tag");

                entity.Property(e => e.TagType)
                    .HasColumnType("integer")
                    .HasColumnName("tag_type");

                entity.Property(e => e.TagValue)
                    .HasColumnType("integer")
                    .HasColumnName("tag_value");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserArtUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_art_url");

                entity.Property(e => e.UserMusicUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_music_url");

                entity.Property(e => e.UserThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_thumb_url");
            });

            modelBuilder.Entity<Tagging>(entity =>
            {
                entity.ToTable("taggings");

                entity.HasIndex(e => e.MetadataItemId, "index_taggings_on_metadata_item_id");

                entity.HasIndex(e => e.TagId, "index_taggings_on_tag_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.EndTimeOffset)
                    .HasColumnType("integer")
                    .HasColumnName("end_time_offset");

                entity.Property(e => e.ExtraData)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extra_data");

                entity.Property(e => e.Index)
                    .HasColumnType("integer")
                    .HasColumnName("index");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.TagId)
                    .HasColumnType("integer")
                    .HasColumnName("tag_id");

                entity.Property(e => e.Text)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("text");

                entity.Property(e => e.ThumbUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb_url");

                entity.Property(e => e.TimeOffset)
                    .HasColumnType("integer")
                    .HasColumnName("time_offset");
            });

            modelBuilder.Entity<VersionedMetadataItem>(entity =>
            {
                entity.ToTable("versioned_metadata_items");

                entity.HasIndex(e => e.GeneratorId, "index_versioned_metadata_items_on_generator_id");

                entity.HasIndex(e => e.MetadataItemId, "index_versioned_metadata_items_on_metadata_item_id");

                entity.HasIndex(e => e.SelectedMediaId, "index_versioned_metadata_items_on_selected_media_id");

                entity.HasIndex(e => e.TargetTagId, "index_versioned_metadata_items_on_target_tag_id");

                entity.HasIndex(e => e.VersionMediaId, "index_versioned_metadata_items_on_version_media_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FileSize)
                    .HasColumnType("integer(8)")
                    .HasColumnName("file_size");

                entity.Property(e => e.GeneratorId)
                    .HasColumnType("integer")
                    .HasColumnName("generator_id");

                entity.Property(e => e.MediaDecision)
                    .HasColumnType("integer")
                    .HasColumnName("media_decision");

                entity.Property(e => e.MetadataItemId)
                    .HasColumnType("integer")
                    .HasColumnName("metadata_item_id");

                entity.Property(e => e.SelectedMediaId)
                    .HasColumnType("integer")
                    .HasColumnName("selected_media_id");

                entity.Property(e => e.State)
                    .HasColumnType("integer")
                    .HasColumnName("state");

                entity.Property(e => e.StateContext)
                    .HasColumnType("integer")
                    .HasColumnName("state_context");

                entity.Property(e => e.TargetTagId)
                    .HasColumnType("integer")
                    .HasColumnName("target_tag_id");

                entity.Property(e => e.VersionMediaId)
                    .HasColumnType("integer")
                    .HasColumnName("version_media_id");
            });

            modelBuilder.Entity<ViewSetting>(entity =>
            {
                entity.ToTable("view_settings");

                entity.HasIndex(e => e.ClientType, "index_view_settings_on_client_type");

                entity.HasIndex(e => e.ViewGroup, "index_view_settings_on_view_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("integer")
                    .HasColumnName("account_id");

                entity.Property(e => e.ClientType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("client_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.SortAsc)
                    .HasColumnType("boolean")
                    .HasColumnName("sort_asc");

                entity.Property(e => e.SortId)
                    .HasColumnType("integer")
                    .HasColumnName("sort_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.ViewGroup)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("view_group");

                entity.Property(e => e.ViewId)
                    .HasColumnType("integer")
                    .HasColumnName("view_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
