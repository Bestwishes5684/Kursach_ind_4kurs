using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach_ind_4kurs.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FioClient = table.Column<string>(nullable: true),
                    AddressClient = table.Column<string>(nullable: true),
                    PhoneClient = table.Column<string>(nullable: true),
                    MailClient = table.Column<string>(nullable: true),
                    PassClient = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "DepositType",
                columns: table => new
                {
                    DepositType1 = table.Column<string>(nullable: false),
                    NameDeposit = table.Column<string>(nullable: true),
                    DescriptionDeposit = table.Column<string>(nullable: true),
                    MinTermDeposit = table.Column<int>(nullable: false),
                    MinSumDeposit = table.Column<decimal>(nullable: false),
                    PercentDeposit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositType", x => x.DepositType1);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FioEmployee = table.Column<string>(nullable: true),
                    AgeEmployee = table.Column<int>(nullable: false),
                    AddressEmployee = table.Column<string>(nullable: true),
                    TelephoneEmployee = table.Column<string>(nullable: true),
                    PassportEmployee = table.Column<string>(nullable: true),
                    PostEmployee = table.Column<string>(nullable: true),
                    SalaryEmploee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    IdValuta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValutaName = table.Column<string>(nullable: true),
                    Kurs1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.IdValuta);
                });

            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    IdDeal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FioClient = table.Column<string>(nullable: true),
                    DealDiscription = table.Column<string>(nullable: true),
                    IdEmployee = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    DateDeal = table.Column<DateTime>(nullable: true),
                    ValutaId = table.Column<int>(nullable: true),
                    IdEmployeeNavigationIdEmployee = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.IdDeal);
                    table.ForeignKey(
                        name: "FK_Deal_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deal_Employee_IdEmployeeNavigationIdEmployee",
                        column: x => x.IdEmployeeNavigationIdEmployee,
                        principalTable: "Employee",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deal_Kurs_ValutaId",
                        column: x => x.ValutaId,
                        principalTable: "Kurs",
                        principalColumn: "IdValuta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deposits",
                columns: table => new
                {
                    DepositId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepositName = table.Column<string>(nullable: true),
                    DepositTerm = table.Column<int>(nullable: false),
                    DepositPrecent = table.Column<double>(nullable: false),
                    DealId = table.Column<int>(nullable: false),
                    CodeDepositType = table.Column<string>(nullable: true),
                    SumDeposits = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposits", x => x.DepositId);
                    table.ForeignKey(
                        name: "FK_Deposits_Deal_DealId",
                        column: x => x.DealId,
                        principalTable: "Deal",
                        principalColumn: "IdDeal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    IdLoan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanTerms = table.Column<DateTime>(nullable: false),
                    LoanPerecent = table.Column<double>(nullable: false),
                    IdDeal = table.Column<int>(nullable: false),
                    IdValuta = table.Column<int>(nullable: false),
                    IdDealNavigationIdDeal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.IdLoan);
                    table.ForeignKey(
                        name: "FK_Loans_Deal_IdDealNavigationIdDeal",
                        column: x => x.IdDealNavigationIdDeal,
                        principalTable: "Deal",
                        principalColumn: "IdDeal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deal_ClientId",
                table: "Deal",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_IdEmployeeNavigationIdEmployee",
                table: "Deal",
                column: "IdEmployeeNavigationIdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_ValutaId",
                table: "Deal",
                column: "ValutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_DealId",
                table: "Deposits",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_IdDealNavigationIdDeal",
                table: "Loans",
                column: "IdDealNavigationIdDeal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "DepositType");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Kurs");
        }
    }
}
