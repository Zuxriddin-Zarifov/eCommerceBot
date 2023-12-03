using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace eCommerceBot.Migrations
{
    /// <inheritdoc />
    public partial class initalize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ecommerce");

            migrationBuilder.CreateTable(
                name: "categories",
                schema: "ecommerce",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "ecommerce",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fio = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                schema: "ecommerce",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_id = table.Column<List<long>>(type: "bigint[]", nullable: true),
                    owner_id = table.Column<long>(type: "bigint", nullable: false),
                    balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carts_users_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "ecommerce",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "ecommerce",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    photo_url = table.Column<string>(type: "text", nullable: false),
                    image_id = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false),
                    category_id = table.Column<long>(type: "bigint", nullable: false),
                    owner_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_category_id",
                        column: x => x.category_id,
                        principalSchema: "ecommerce",
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_users_owner_id",
                        column: x => x.owner_id,
                        principalSchema: "ecommerce",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carts_owner_id",
                schema: "ecommerce",
                table: "carts",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                schema: "ecommerce",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_owner_id",
                schema: "ecommerce",
                table: "products",
                column: "owner_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carts",
                schema: "ecommerce");

            migrationBuilder.DropTable(
                name: "products",
                schema: "ecommerce");

            migrationBuilder.DropTable(
                name: "categories",
                schema: "ecommerce");

            migrationBuilder.DropTable(
                name: "users",
                schema: "ecommerce");
        }
    }
}
