using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Undefine.Web.Migrations
{
    public partial class UndefineDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sys_Module",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserId = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserName = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyUserName = table.Column<string>(maxLength: 30, nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Url = table.Column<string>(maxLength: 255, nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsAutoExpand = table.Column<bool>(nullable: false),
                    ParentId = table.Column<string>(maxLength: 100, nullable: false),
                    ParentName = table.Column<string>(maxLength: 30, nullable: false),
                    Enabled = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Module", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ModuleElement",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserId = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserName = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyUserName = table.Column<string>(maxLength: 30, nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    DomId = table.Column<string>(maxLength: 30, nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    BgColor = table.Column<string>(maxLength: 50, nullable: false),
                    Remark = table.Column<string>(maxLength: 255, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    ModuleId = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ModuleElement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Relevance",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    Key = table.Column<string>(maxLength: 30, nullable: false),
                    FirstId = table.Column<string>(maxLength: 100, nullable: false),
                    SecondId = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Relevance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserId = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserName = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyUserName = table.Column<string>(maxLength: 30, nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserId = table.Column<string>(maxLength: 100, nullable: false),
                    CreationUserName = table.Column<string>(maxLength: 30, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    ModifyUserId = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyUserName = table.Column<string>(maxLength: 30, nullable: false),
                    ModifyTime = table.Column<DateTime>(nullable: true),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Account = table.Column<string>(maxLength: 30, nullable: false),
                    PassWord = table.Column<string>(maxLength: 255, nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    LastLoginIp = table.Column<string>(maxLength: 30, nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sys_Module");

            migrationBuilder.DropTable(
                name: "Sys_ModuleElement");

            migrationBuilder.DropTable(
                name: "Sys_Relevance");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_User");
        }
    }
}
