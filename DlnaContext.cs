using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PlexContext
{
    using Dlna;

    public partial class DlnaContext : DbContext
    {
        public DlnaContext()
        {
        }

        public DlnaContext(DbContextOptions<DlnaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ObjectId> ObjectIds { get; set; }
        public virtual DbSet<RemoteServer> RemoteServers { get; set; }
        public virtual DbSet<ShortKey> ShortKeys { get; set; }
        public virtual DbSet<Version> Versions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObjectId>(entity =>
            {
                entity.HasKey(e => e.Content);

                entity.ToTable("object_ids");

                entity.HasIndex(e => e.LastAccessedTimeT, "index_object_ids_on_last_accessed_time_t");

                entity.HasIndex(e => e.MachineIdentifier, "index_object_ids_on_machine_identifier");

                entity.HasIndex(e => e.Content, "index_object_ids_on_object_id");

                entity.HasIndex(e => e.PlexPath, "index_object_ids_on_plex_path");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("object_id");

                entity.Property(e => e.LastAccessedTimeT)
                    .HasColumnType("BIGINT")
                    .HasColumnName("last_accessed_time_t");

                entity.Property(e => e.MachineIdentifier)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("machine_identifier");

                entity.Property(e => e.ParentMachineIdentifier)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parent_machine_identifier");

                entity.Property(e => e.ParentObjectId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("parent_object_id");

                entity.Property(e => e.Part)
                    .HasColumnType("integer")
                    .HasColumnName("part");

                entity.Property(e => e.PlexParentPath)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("plex_parent_path");

                entity.Property(e => e.PlexPath)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("plex_path");
            });

            modelBuilder.Entity<RemoteServer>(entity =>
            {
                entity.HasKey(e => e.MachineIdentifier);

                entity.ToTable("remote_servers");

                entity.HasIndex(e => e.MachineIdentifier, "index_remote_servers_on_machine_identifier");

                entity.Property(e => e.MachineIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("machine_identifier");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("access_token");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("url");
            });

            modelBuilder.Entity<ShortKey>(entity =>
            {
                entity.HasKey(e => e.ShaKeyId);

                entity.ToTable("short_keys");

                entity.HasIndex(e => e.LastAccessedTimeT, "index_short_keys_on_last_accessed_time_t");

                entity.HasIndex(e => e.MachineIdentifier, "index_short_keys_on_machine_identifier");

                entity.HasIndex(e => e.PlexKey, "index_short_keys_on_plex_key");

                entity.HasIndex(e => e.Content, "index_short_keys_on_short_key");

                entity.Property(e => e.ShaKeyId)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("sha_key_id");

                entity.Property(e => e.LastAccessedTimeT)
                    .HasColumnType("BIGINT")
                    .HasColumnName("last_accessed_time_t");

                entity.Property(e => e.MachineIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("machine_identifier");

                entity.Property(e => e.PlexKey)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("plex_key");

                entity.Property(e => e.PlexPath)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("plex_path");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("short_key");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("version");

                entity.Property(e => e.Content).HasColumnName("version");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
