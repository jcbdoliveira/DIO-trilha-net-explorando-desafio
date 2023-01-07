using System.Text;
using DesafioProjetoHospedagem.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Seja bem vindo ao sistema de testes de hospedagem!");

        string opcao = string.Empty;
        bool exibirMenu = true;

        PrintText pr = new PrintText();

        // Realiza o loop do menu
        while (exibirMenu)
        {
            Console.Clear();
            pr.printColorText("Digite a sua opção para teste:", 0);
            pr.printColorText("1 - Teste 01: 2 hóspedes e 5 dias de reserva (sem desconto) ", 1);
            pr.printColorText("2 - Teste 02: 2 hóspedes e 10 dias de reserva (tem desconto)", 3);
            pr.printColorText("3 - Teste 03: 5 hóspedes e 3 dias de reserva (exception)", 2);
            pr.printColorText("4 - Encerrar", 0);

            switch (Console.ReadLine())
            {
                case "1":
                   teste01();
                   break;

                case "2":
                    teste02();
                    break;

                case "3":
                    teste03();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O programa se encerrou");
    }

     private static void teste01()
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 30);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 5);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
    
    private static void teste02()
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 30);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
    
     private static void teste03()
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");
            Pessoa p3 = new Pessoa(nome: "Hóspede 3");
            Pessoa p4 = new Pessoa(nome: "Hóspede 4");
            Pessoa p5 = new Pessoa(nome: "Hóspede 5");

            hospedes.AddRange(new List<Pessoa>{p1, p2, p3, p4, p5});

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 3);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
}