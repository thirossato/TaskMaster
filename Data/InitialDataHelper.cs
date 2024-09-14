using TaskMaster.Models;

namespace TaskMaster.Data
{
    public static class InitialDataHelper
    {
        public static List<UserTask> SeedData()
        {
            var today = DateTime.Now.Date;
            var tomorrow = today.AddDays(1);
            var endOfWeek = today.AddDays(7 - (int)today.DayOfWeek); // Último dia da semana (domingo)
            List<UserTask> userTasks = new List<UserTask>();
            userTasks.AddRange([
                new UserTask
                {
                    Id = 1,
                    Description = "Descrição da tarefa 1",
                    DueDate = new DateTime(2024, 12, 31),
                    Priority = "Alta",
                    Status = "Não Iniciata",
                    Title = "Tarefa 1"
                }, new UserTask
                {
                    Id = 2,
                    Description = "Descrição da tarefa 2",
                    DueDate = new DateTime(2024, 11, 15),
                    Priority = "Média",
                    Status = "Em Progresso",
                    Title = "Tarefa 2"
                }, new UserTask
                {
                    Id = 3,
                    Description = "Descrição da tarefa 3",
                    DueDate = new DateTime(2024, 10, 05),
                    Priority = "Baixa",
                    Status = "Concluída",
                    Title = "Tarefa 3"
                }, new UserTask
                {
                    Id = 4,
                    Description = "Descrição da tarefa 4",
                    DueDate = new DateTime(2025, 01, 20),
                    Priority = "Alta",
                    Status = "Não Iniciada",
                    Title = "Tarefa 4"
                }, new UserTask
                {
                    Id = 5,
                    Description = "Descrição da tarefa 5",
                    DueDate = new DateTime(2024, 09, 25),
                    Priority = "Média",
                    Status = "Em Progresso",
                    Title = "Tarefa 5"
                }, new UserTask
                {
                    Id = 6,
                    Description = "Descrição da tarefa 6",
                    DueDate = new DateTime(2024, 12, 01),
                    Priority = "Alta",
                    Status = "Não Iniciata",
                    Title = "Tarefa 6"
                },
                // Vencem hoje
                new UserTask
                {
                    Id = 7,
                    Description = "Tarefa vencendo hoje 1",
                    DueDate = today,
                    Priority = "Alta",
                    Status = "Pendente",
                    Title = "Tarefa 7"
                },
                new UserTask
                {
                    Id = 8,
                    Description = "Tarefa vencendo hoje 2",
                    DueDate = today,
                    Priority = "Média",
                    Status = "Em Progresso",
                    Title = "Tarefa 8"
                },

                // Vencem amanhã
                new UserTask
                {
                    Id = 9,
                    Description = "Tarefa vencendo amanhã 1",
                    DueDate = tomorrow,
                    Priority = "Baixa",
                    Status = "Pendente",
                    Title = "Tarefa 9"
                },
                new UserTask
                {
                    Id = 10,
                    Description = "Tarefa vencendo amanhã 2",
                    DueDate = tomorrow,
                    Priority = "Alta",
                    Status = "Em Progresso",
                    Title = "Tarefa 10"
                },

                // Vencem ainda esta semana
                new UserTask
                {
                    Id = 11,
                    Description = "Tarefa vencendo esta semana 1",
                    DueDate = today.AddDays(3),
                    Priority = "Média",
                    Status = "Pendente",
                    Title = "Tarefa 11"
                },
                new UserTask
                {
                    Id = 12,
                    Description = "Tarefa vencendo esta semana 2",
                    DueDate = today.AddDays(4),
                    Priority = "Baixa",
                    Status = "Não Iniciada",
                    Title = "Tarefa 12"
                },
                new UserTask
                {
                    Id = 13,
                    Description = "Tarefa vencendo esta semana 3",
                    DueDate = today.AddDays(5),
                    Priority = "Alta",
                    Status = "Em Progresso",
                    Title = "Tarefa 13"
                },
                new UserTask
                {
                    Id = 14,
                    Description = "Tarefa vencendo esta semana 4",
                    DueDate = endOfWeek,
                    Priority = "Média",
                    Status = "Pendente",
                    Title = "Tarefa 14"
                },
                new UserTask
                {
                    Id = 15,
                    Description = "Tarefa vencendo esta semana 5",
                    DueDate = endOfWeek,
                    Priority = "Baixa",
                    Status = "Concluída",
                    Title = "Tarefa 15"
                }]
            );
            return userTasks;
        }
    }
}
