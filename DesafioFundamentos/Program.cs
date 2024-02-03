using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear(); //*ALLAN*: inserido para limpar o Console caso esteja executando o programa mais de uma vez
Console.Write("                  _______ \n"
+"                 //  ||\\ \\ \n"
+"           _____//___||_\\ \\___ \n"
+"           )  _          _    \\ \n"
+"           |_/ \\________/ \\___| \n"
+"_____________\\_/________\\_/_____________________ \n");
Console.WriteLine("## Seja bem vindo ao sistema de estacionamento! ##\nDigite o preço inicial do Estacionamento:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora de estadis no Estacionamento:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("\nOpção inválida\nDigite um número entre 1 e 4");
            break;
    }

    Console.WriteLine("\n## Pressione ENTER para continuar ##");
    Console.ReadLine();
}

Console.WriteLine("## Programa encerrado ##");
