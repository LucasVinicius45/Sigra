using System;
using System.Collections.Generic;
using Sigra.Model;

class Program
{
    static List<PowerFailure> failures = new();
    static List<EventLog> logs = new();

    static void Main()
    {
        var user = new User("admin", "123");

        Console.WriteLine("🔐 Login");
        Console.Write("Usuário: ");
        string name = Console.ReadLine();
        Console.Write("Senha: ");
        string password = Console.ReadLine();

        if (!user.ValidateLogin(name, password))
        {
            Console.WriteLine("Acesso negado.");
            return;
        }

        int option;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Registrar Falha");
            Console.WriteLine("2 - Ver Logs");
            Console.WriteLine("3 - Gerar Relatório");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    RegisterFailure();
                    break;
                case 2:
                    ShowLogs();
                    break;
                case 3:
                    Console.WriteLine(Report.GenerateSummary(failures));
                    break;
            }

        } while (option != 0);
    }

    static void RegisterFailure()
    {
        try
        {
            Console.Write("📍 Local: ");
            string location = Console.ReadLine();

            Console.Write("⚡ Tipo de falha: ");
            string type = Console.ReadLine();

            Console.Write("❗ Região crítica? (s/n): ");
            bool critical = Console.ReadLine().Trim().ToLower() == "s";

            Console.Write("💻 Impacto cibernético (ou deixe vazio): ");
            string impact = Console.ReadLine();

            var failure = new PowerFailure(DateTime.Now, location, type, critical, impact);
            failures.Add(failure);
            logs.Add(new EventLog($"Falha registrada: {failure.GetSummary()}"));

            if (Alert.ShouldTriggerAlert(failure))
            {
                string alert = Alert.GetMessage(failure);
                Console.WriteLine(alert);
                logs.Add(new EventLog(alert));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }

    static void ShowLogs()
    {
        Console.WriteLine("\n📄 LOG DE EVENTOS:");
        foreach (var log in logs)
        {
            Console.WriteLine(log.GetEntry());
        }
    }
}
