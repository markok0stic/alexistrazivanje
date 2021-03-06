// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace backend.Migrations
{
    [DbContext(typeof(IstrazivanjeContext))]
    partial class IstrazivanjeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IDgenerated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentILIPevanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentKojiSvira")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obrazovanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Starost")
                        .HasColumnType("int");

                    b.Property<DateTime>("VremeIDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("VremeProvedenoSviranjemInsturmenta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.RezultatiTesta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Odgovor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resenje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VremeReakcije")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("RezultatiTesta");
                });

            modelBuilder.Entity("Models.RezultatiTesta", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithMany("RezultatiTesta")
                        .HasForeignKey("KorisnikID");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("RezultatiTesta");
                });
#pragma warning restore 612, 618
        }
    }
}
