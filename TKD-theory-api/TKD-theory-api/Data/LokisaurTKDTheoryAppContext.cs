using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TKD_theory_api.Data
{
    public partial class LokisaurTKDTheoryAppContext : DbContext
    {
        public LokisaurTKDTheoryAppContext()
        {
        }

        public LokisaurTKDTheoryAppContext(DbContextOptions<LokisaurTKDTheoryAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DanTheoryItems> DanTheoryItems { get; set; }
        public virtual DbSet<EngTheoryItems> EngTheoryItems { get; set; }
        public virtual DbSet<KorTheoryItems> KorTheoryItems { get; set; }
        public virtual DbSet<TheoryLanguages> TheoryLanguages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<DanTheoryItems>(entity =>
            {
                entity.ToTable("DAN_theory_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.KoreanTheoryItemId).HasColumnName("korean_theory_item_id");

                entity.Property(e => e.MainCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NameAudio)
                    .HasColumnName("Name_audio")
                    .HasMaxLength(100);

                entity.Property(e => e.NameLatin)
                    .IsRequired()
                    .HasColumnName("Name_latin")
                    .HasMaxLength(100);

                entity.Property(e => e.NamePhonetic)
                    .HasColumnName("Name_phonetic")
                    .HasMaxLength(100);

                entity.Property(e => e.SubCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SubToSubCategory).HasColumnType("text");
            });

            modelBuilder.Entity<EngTheoryItems>(entity =>
            {
                entity.ToTable("ENG_theory_items");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.KoreanTheoryItemId).HasColumnName("korean_theory_item_id");

                entity.Property(e => e.MainCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NameAudio)
                    .HasColumnName("Name_audio")
                    .HasMaxLength(100);

                entity.Property(e => e.NameLatin)
                    .IsRequired()
                    .HasColumnName("Name_latin")
                    .HasMaxLength(100);

                entity.Property(e => e.NamePhonetic)
                    .HasColumnName("Name_phonetic")
                    .HasMaxLength(100);

                entity.Property(e => e.SubCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SubToSubCategory).HasColumnType("text");
            });

            modelBuilder.Entity<KorTheoryItems>(entity =>
            {
                entity.ToTable("KOR_theory_items");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MainCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NameAudio)
                    .HasColumnName("Name_audio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameHangul)
                    .HasColumnName("Name_hangul")
                    .HasMaxLength(100);

                entity.Property(e => e.NameLatin)
                    .IsRequired()
                    .HasColumnName("Name_latin")
                    .HasColumnType("text");

                entity.Property(e => e.NamePhonetic)
                    .HasColumnName("Name_phonetic")
                    .HasMaxLength(100);

                entity.Property(e => e.SubCategory)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SubToSubCategory).HasColumnType("text");
            });

            modelBuilder.Entity<TheoryLanguages>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("Theory_languages");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("text");
            });
        }
    }
}
