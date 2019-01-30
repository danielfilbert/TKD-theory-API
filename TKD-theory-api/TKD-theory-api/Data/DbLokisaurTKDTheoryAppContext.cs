using Microsoft.EntityFrameworkCore;

namespace TKD_theory_api.Data
{
    public partial class DbLokisaurTKDTheoryAppContext : DbContext, IDbContext
    {
        public DbLokisaurTKDTheoryAppContext()
        {
        }

        public DbLokisaurTKDTheoryAppContext(DbContextOptions<DbLokisaurTKDTheoryAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DbDanTheoryItems> DanTheoryItems { get; set; }
        public virtual DbSet<DbEngTheoryItems> EngTheoryItems { get; set; }
        public virtual DbSet<DbKorTheoryItems> KorTheoryItems { get; set; }
        public virtual DbSet<DbTheoryLanguages> TheoryLanguages { get; set; }
        public virtual DbSet<DbUsers> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<DbDanTheoryItems>(entity =>
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

            modelBuilder.Entity<DbEngTheoryItems>(entity =>
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

            modelBuilder.Entity<DbKorTheoryItems>(entity =>
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

            modelBuilder.Entity<DbTheoryLanguages>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("Theory_languages");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<DbUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmailAdress)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });
        }
    }
}
