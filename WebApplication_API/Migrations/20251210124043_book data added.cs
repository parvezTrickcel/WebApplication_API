using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication_API.Migrations
{
    /// <inheritdoc />
    public partial class bookdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "MyProperty", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", 0, "The Great Gatsby", 1925 },
                    { 2, "Harper Lee", 0, "To Kill a Mockingbird", 1960 },
                    { 3, "George Orwell", 0, "1984", 1949 },
                    { 4, "Jane Austen", 0, "Pride and Prejudice", 1813 },
                    { 5, "J.R.R. Tolkien", 0, "The Hobbit", 1937 },
                    { 6, "Herman Melville", 0, "Moby-Dick", 1851 },
                    { 7, "Aldous Huxley", 0, "Brave New World", 1932 },
                    { 8, "J.D. Salinger", 0, "The Catcher in the Rye", 1951 },
                    { 9, "Leo Tolstoy", 0, "War and Peace", 1869 },
                    { 10, "Fyodor Dostoevsky", 0, "Crime and Punishment", 1866 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
