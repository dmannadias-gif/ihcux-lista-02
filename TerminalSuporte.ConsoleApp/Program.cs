using System;
using System.Text.RegularExpressions;

namespace TerminalSuporte.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarSistema();
        }

        static void ExecutarSistema()
        {
            while (true)
            {
                Console.Clear();
                MostrarCabecalho();
                MostrarMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nDigite uma opção: ");
                Console.ResetColor();

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "1":
                        Ping();
                        break;

                    case "2":
                        Reiniciar();
                        break;

                    case "3":
                        Formatar();
                        break;

                    case "help":
                    case "?":
                        Ajuda();
                        break;

                    case "0":
                        Console.WriteLine("\nEncerrando o sistema...");
                        return;

                    default:
                        MensagemErro("Comando não reconhecido. Digite 'help' para ajuda.");
                        Pausar();
                        break;
                }
            }
        }

        // ================= INTERFACE =================

        static void MostrarCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========================================");
            Console.WriteLine("   TERMINAL DE SUPORTE PROATIVO");
            Console.WriteLine("========================================");
            Console.ResetColor();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("\nMENU DE COMANDOS:");
            Console.WriteLine("[1] Pingar IP");
            Console.WriteLine("[2] Reiniciar Servidor");
            Console.WriteLine("[3] Formatar Unidade");
            Console.WriteLine("[help/?] Ajuda");
            Console.WriteLine("[0] Sair");
        }

        // ================= FUNCIONALIDADES =================

        static void Ping()
        {
            Console.Write("\nDigite o IP: ");
            string ip = Console.ReadLine();

            if (!ValidarIP(ip))
            {
                MensagemAviso("IP inválido! Utilize o formato correto: xxx.xxx.xxx.xxx");
                Pausar();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nConectando ao IP {ip}...");
            Console.WriteLine("Resposta recebida com sucesso!");
            Console.ResetColor();

            Pausar();
        }

        static bool ValidarIP(string ip)
        {
            string padrao = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(ip, padrao);
        }

        static void Reiniciar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠ ATENÇÃO: Você está prestes a reiniciar o servidor.");
            Console.ResetColor();

            Console.Write("Deseja continuar? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nServidor reiniciado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nOperação cancelada.");
            }

            Console.ResetColor();
            Pausar();
        }

        static void Formatar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n🚨 PERIGO: Esta ação apagará TODOS os dados!");
            Console.ResetColor();

            Console.Write("Digite 'CONFIRMAR' para prosseguir: ");
            string confirmacao = Console.ReadLine();

            if (confirmacao == "CONFIRMAR")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUnidade formatada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nOperação cancelada com segurança.");
            }

            Console.ResetColor();
            Pausar();
        }

        static void Ajuda()
        {
            Console.WriteLine("\n===== AJUDA DO SISTEMA =====");
            Console.WriteLine("1 - Testa conexão com um IP (Ping)");
            Console.WriteLine("2 - Reinicia o servidor (com confirmação)");
            Console.WriteLine("3 - Formata unidade (ação crítica)");
            Console.WriteLine("help/? - Mostra esta tela");
            Console.WriteLine("0 - Sai do sistema");

            Pausar();
        }

        // ================= UX =================

        static void MensagemErro(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERRO: {msg}");
            Console.ResetColor();
        }

        static void MensagemAviso(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nAVISO: {msg}");
            Console.ResetColor();
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}