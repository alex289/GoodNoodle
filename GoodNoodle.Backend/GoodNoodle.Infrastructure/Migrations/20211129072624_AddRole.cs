﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodNoodle.Infrastructure.Migrations;

public partial class AddRole : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "Role",
            table: "NoodleUser",
            type: "int",
            nullable: false,
            defaultValue: 0);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Role",
            table: "NoodleUser");
    }
}
