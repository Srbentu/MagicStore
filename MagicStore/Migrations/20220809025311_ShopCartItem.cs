using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicStore.Migrations
{
    /// <inheritdoc />
    public partial class ShopCartItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shopCartId",
                table: "ShopCartItem",
                newName: "ShopCartId");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "ShopCartItem",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopCartId",
                table: "ShopCartItem",
                newName: "shopCartId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ShopCartItem",
                newName: "amount");
        }
    }
}
