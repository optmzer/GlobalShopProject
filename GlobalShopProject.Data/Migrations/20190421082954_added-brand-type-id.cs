using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalShopProject.Data.Migrations
{
    public partial class addedbrandtypeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogBrands_CatalogBrandsId",
                table: "CatalogItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypesId",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogTypesId",
                table: "CatalogItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatalogBrandsId",
                table: "CatalogItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogBrands_CatalogBrandsId",
                table: "CatalogItems",
                column: "CatalogBrandsId",
                principalTable: "CatalogBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypesId",
                table: "CatalogItems",
                column: "CatalogTypesId",
                principalTable: "CatalogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogBrands_CatalogBrandsId",
                table: "CatalogItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypesId",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogTypesId",
                table: "CatalogItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CatalogBrandsId",
                table: "CatalogItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogBrands_CatalogBrandsId",
                table: "CatalogItems",
                column: "CatalogBrandsId",
                principalTable: "CatalogBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypesId",
                table: "CatalogItems",
                column: "CatalogTypesId",
                principalTable: "CatalogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
