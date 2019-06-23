using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Database.Migrations
{
    public partial class OrderStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StripeReference",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderStocks",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    Quality = table.Column<int>(nullable: false),
                    StockID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStocks", x => new { x.StockID, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderStocks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderStocks_Stock_StockID",
                        column: x => x.StockID,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderStocks_OrderId",
                table: "OrderStocks",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderStocks");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StripeReference",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");
        }
    }
}
