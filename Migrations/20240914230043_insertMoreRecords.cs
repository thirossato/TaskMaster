using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskMaster.Migrations
{
    /// <inheritdoc />
    public partial class insertMoreRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: "Não Iniciata");

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { 7, "Tarefa vencendo hoje 1", new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Alta", "Pendente", "Tarefa 7" },
                    { 8, "Tarefa vencendo hoje 2", new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Média", "Em Progresso", "Tarefa 8" },
                    { 9, "Tarefa vencendo amanhã 1", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Baixa", "Pendente", "Tarefa 9" },
                    { 10, "Tarefa vencendo amanhã 2", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Alta", "Em Progresso", "Tarefa 10" },
                    { 11, "Tarefa vencendo esta semana 1", new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Média", "Pendente", "Tarefa 11" },
                    { 12, "Tarefa vencendo esta semana 2", new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Baixa", "Não Iniciada", "Tarefa 12" },
                    { 13, "Tarefa vencendo esta semana 3", new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Alta", "Em Progresso", "Tarefa 13" },
                    { 14, "Tarefa vencendo esta semana 4", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Média", "Pendente", "Tarefa 14" },
                    { 15, "Tarefa vencendo esta semana 5", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Baixa", "Concluída", "Tarefa 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: "Concluída");
        }
    }
}
