using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakHos.Data.Migrations
{
    /// <inheritdoc />
    public partial class ıC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muayanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiseGelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaSorunu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuayaneCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YapilanIslemler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SosyalGuvencesiVarMi = table.Column<bool>(type: "bit", nullable: false),
                    HastaTC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poliklinik = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muayanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Polikliniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polikliniks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doktors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolikinikId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoliklinikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktors_Polikliniks_PoliklinikId",
                        column: x => x.PoliklinikId,
                        principalTable: "Polikliniks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hastas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hastas_Doktors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    HastaId = table.Column<int>(type: "int", nullable: false),
                    SatisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevus_Doktors_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Randevus_Hastas_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "Adi" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Adi", "AktifMi", "EklenmeTarihi", "Email", "KullaniciAdi", "RolId", "Sifre", "Soyadi", "Telefon" },
                values: new object[] { 2, "Admin", true, new DateTime(2023, 8, 3, 20, 20, 58, 942, DateTimeKind.Local).AddTicks(5733), "admin@pashos.tc", "admin", 1, "123456", "admin", "123" });

            migrationBuilder.CreateIndex(
                name: "IX_Doktors_PoliklinikId",
                table: "Doktors",
                column: "PoliklinikId");

            migrationBuilder.CreateIndex(
                name: "IX_Hastas_DoktorId",
                table: "Hastas",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_RolId",
                table: "Kullanicilar",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_DoktorId",
                table: "Randevus",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_HastaId",
                table: "Randevus",
                column: "HastaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Muayanes");

            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Hastas");

            migrationBuilder.DropTable(
                name: "Doktors");

            migrationBuilder.DropTable(
                name: "Polikliniks");
        }
    }
}
