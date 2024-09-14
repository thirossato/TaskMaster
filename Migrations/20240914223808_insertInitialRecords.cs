using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskMaster.Migrations
{
    /// <inheritdoc />
    public partial class insertInitialRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "Descrição da tarefa 1", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alta", "Não Iniciata", "Tarefa 1" },
                    { 2, "Descrição da tarefa 2", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Média", "Em Progresso", "Tarefa 2" },
                    { 3, "Descrição da tarefa 3", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baixa", "Concluída", "Tarefa 3" },
                    { 4, "Descrição da tarefa 4", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alta", "Não Iniciada", "Tarefa 4" },
                    { 5, "Descrição da tarefa 5", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Média", "Em Progresso", "Tarefa 5" },
                    { 6, "Descrição da tarefa 6", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alta", "Concluída", "Tarefa 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
