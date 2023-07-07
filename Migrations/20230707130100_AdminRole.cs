using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
                (@"
                    IF NOT EXISTS(Select Id from AspNetRoles where Id = 'a1ed5b01-cf74-4423-9447-08fcb81e52b5')
                    BEGIN
	                INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                VALUES ('a1ed5b01-cf74-4423-9447-08fcb81e52b5', 'admin', 'ADMIN')
                    END
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql
                (@"
                    DELETE AspNetRoles where Id = 'a1ed5b01-cf74-4423-9447-08fcb81e52b5'
                ");
        }
    }
}
