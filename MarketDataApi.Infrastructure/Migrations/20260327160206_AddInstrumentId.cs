using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketDataApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInstrumentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5bbd-7bf6-975a-19a538210610"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5be1-73e9-9797-8eac7cda5349"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c0c-7356-8f75-f627cd37f302"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c16-7217-8108-2a1dfe834b90"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c36-7326-b890-d37568bd3637"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c41-7907-b0d7-1eb0dd665012"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c57-7a5e-bed8-f0e7a7558526"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c6f-7eac-b85c-0c9dd8a09e4b"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5c79-7f09-993b-8e0e996f58fe"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5ccd-7064-bb8c-4aa47a93c6f1"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5d0c-7111-9df6-fa14c5f4c87d"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5d23-7009-9ced-057bc85fbdf3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5d5b-73a3-a2e8-5c537ee593cd"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5d82-75a9-9df4-fde04e4fd481"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5da5-76fc-b6c0-1b9c270040c3"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5dbb-7cc9-ba07-0ddb62828135"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5e3d-7dc8-b4c3-fa4cc90997ba"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5e7a-7199-b906-93f3e818bf62"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-5ec6-7a27-b223-fa0c0f5b13c6"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("019cfb9b-6035-7777-8217-f936ffaed040"));

            migrationBuilder.AddColumn<string>(
                name: "InstrumentId",
                table: "Assets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "InstrumentId", "Kind", "Symbol" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111001"), "019cfb9b-5d5b-73a3-a2e8-5c537ee593cd", "forex", "EURUSD" },
                    { new Guid("11111111-1111-1111-1111-111111111002"), "019cfb9b-5be1-73e9-9797-8eac7cda5349", "forex", "GBPUSD" },
                    { new Guid("11111111-1111-1111-1111-111111111003"), "019cfb9b-5c16-7217-8108-2a1dfe834b90", "forex", "USDJPY" },
                    { new Guid("11111111-1111-1111-1111-111111111004"), "019cfb9b-5c79-7f09-993b-8e0e996f58fe", "forex", "USDCHF" },
                    { new Guid("11111111-1111-1111-1111-111111111005"), "019cfb9b-5e7a-7199-b906-93f3e818bf62", "forex", "USDCAD" },
                    { new Guid("11111111-1111-1111-1111-111111111006"), "019cfb9b-5c36-7326-b890-d37568bd3637", "forex", "AUDUSD" },
                    { new Guid("11111111-1111-1111-1111-111111111007"), "019cfb9b-5c0c-7356-8f75-f627cd37f302", "forex", "AUDNZD" },
                    { new Guid("11111111-1111-1111-1111-111111111008"), "019cfb9b-5da5-76fc-b6c0-1b9c270040c3", "forex", "AUDJPY" },
                    { new Guid("11111111-1111-1111-1111-111111111009"), "019cfb9b-5ccd-7064-bb8c-4aa47a93c6f1", "forex", "EURAUD" },
                    { new Guid("11111111-1111-1111-1111-111111111010"), "019cfb9b-5bbd-7bf6-975a-19a538210610", "forex", "EURCAD" },
                    { new Guid("11111111-1111-1111-1111-111111111011"), "019cfb9b-5d23-7009-9ced-057bc85fbdf3", "forex", "EURCHF" },
                    { new Guid("11111111-1111-1111-1111-111111111012"), "019cfb9b-5c6f-7eac-b85c-0c9dd8a09e4b", "forex", "EURGBP" },
                    { new Guid("11111111-1111-1111-1111-111111111013"), "019cfb9b-5d82-75a9-9df4-fde04e4fd481", "forex", "EURJPY" },
                    { new Guid("11111111-1111-1111-1111-111111111014"), "019cfb9b-5e3d-7dc8-b4c3-fa4cc90997ba", "forex", "EURNZD" },
                    { new Guid("11111111-1111-1111-1111-111111111015"), "019cfb9b-5d0c-7111-9df6-fa14c5f4c87d", "forex", "GBPJPY" },
                    { new Guid("11111111-1111-1111-1111-111111111016"), "019cfb9b-5dbb-7cc9-ba07-0ddb62828135", "forex", "GBPCHF" },
                    { new Guid("11111111-1111-1111-1111-111111111017"), "019cfb9b-5c57-7a5e-bed8-f0e7a7558526", "forex", "NZDUSD" },
                    { new Guid("11111111-1111-1111-1111-111111111018"), "019cfb9b-6035-7777-8217-f936ffaed040", "forex", "NZDCHF" },
                    { new Guid("11111111-1111-1111-1111-111111111019"), "019cfb9b-5ec6-7a27-b223-fa0c0f5b13c6", "forex", "USDSEK" },
                    { new Guid("11111111-1111-1111-1111-111111111020"), "019cfb9b-5c41-7907-b0d7-1eb0dd665012", "forex", "USDPLN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111001"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111002"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111003"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111004"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111005"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111006"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111007"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111008"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111009"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111010"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111011"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111012"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111013"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111014"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111015"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111016"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111017"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111018"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111019"));

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111020"));

            migrationBuilder.DropColumn(
                name: "InstrumentId",
                table: "Assets");

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Kind", "Symbol" },
                values: new object[,]
                {
                    { new Guid("019cfb9b-5bbd-7bf6-975a-19a538210610"), "forex", "EURCAD" },
                    { new Guid("019cfb9b-5be1-73e9-9797-8eac7cda5349"), "forex", "GBPUSD" },
                    { new Guid("019cfb9b-5c0c-7356-8f75-f627cd37f302"), "forex", "AUDNZD" },
                    { new Guid("019cfb9b-5c16-7217-8108-2a1dfe834b90"), "forex", "USDJPY" },
                    { new Guid("019cfb9b-5c36-7326-b890-d37568bd3637"), "forex", "AUDUSD" },
                    { new Guid("019cfb9b-5c41-7907-b0d7-1eb0dd665012"), "forex", "USDPLN" },
                    { new Guid("019cfb9b-5c57-7a5e-bed8-f0e7a7558526"), "forex", "NZDUSD" },
                    { new Guid("019cfb9b-5c6f-7eac-b85c-0c9dd8a09e4b"), "forex", "EURGBP" },
                    { new Guid("019cfb9b-5c79-7f09-993b-8e0e996f58fe"), "forex", "USDCHF" },
                    { new Guid("019cfb9b-5ccd-7064-bb8c-4aa47a93c6f1"), "forex", "EURAUD" },
                    { new Guid("019cfb9b-5d0c-7111-9df6-fa14c5f4c87d"), "forex", "GBPJPY" },
                    { new Guid("019cfb9b-5d23-7009-9ced-057bc85fbdf3"), "forex", "EURCHF" },
                    { new Guid("019cfb9b-5d5b-73a3-a2e8-5c537ee593cd"), "forex", "EURUSD" },
                    { new Guid("019cfb9b-5d82-75a9-9df4-fde04e4fd481"), "forex", "EURJPY" },
                    { new Guid("019cfb9b-5da5-76fc-b6c0-1b9c270040c3"), "forex", "AUDJPY" },
                    { new Guid("019cfb9b-5dbb-7cc9-ba07-0ddb62828135"), "forex", "GBPCHF" },
                    { new Guid("019cfb9b-5e3d-7dc8-b4c3-fa4cc90997ba"), "forex", "EURNZD" },
                    { new Guid("019cfb9b-5e7a-7199-b906-93f3e818bf62"), "forex", "USDCAD" },
                    { new Guid("019cfb9b-5ec6-7a27-b223-fa0c0f5b13c6"), "forex", "USDSEK" },
                    { new Guid("019cfb9b-6035-7777-8217-f936ffaed040"), "forex", "NZDCHF" }
                });
        }
    }
}
