﻿// Screen Sound
string MensagemDeVindas = "Boas vindas ao Screen Sound!!";
List<string> Listarbandas = new List<string>();
void ExibirLogo()
{
    Console.WriteLine(@"
     
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(@"
     
█▄▄ █▄█   █▀▄ ▄▀█ █░█ █▄█   █▀█ █▀▀ █▀ █▀ █▀█ ▄▀█
█▄█ ░█░   █▄▀ █▀█ ▀▄▀ ░█░   █▀▀ ██▄ ▄█ ▄█ █▄█ █▀█
");
    Console.WriteLine("=====================================");
    Console.WriteLine(MensagemDeVindas);
    Console.WriteLine("=====================================");
}

void Exibirmenus() // Isso é um chamada de função
{
    ExibirLogo();// Já chama a logo mais a mensagem de boas vindas dentro do código evitando poluição no ambiente de produção
    Console.WriteLine("\n1. Cadastras Bandas");
    Console.WriteLine("2. Listar Bandas");
    Console.WriteLine("3. Avaliar Bandas");
    Console.WriteLine("4. Avaliação Média das Bandas");

    Console.Write("\nDigite -1 para sair:");
    string opcaoescolhida = Console.ReadLine()!; // Obtém a opção escolhida pelo usuário
    int opcaoescolhidanumerica = int.Parse(opcaoescolhida); // Converte o tipo do valor de string para int
    switch (opcaoescolhidanumerica) // Isso serve como estrutura de condições if e else, só que de uma forma mais simples e menos complexa
    {
        case 1: RegistrarBanda();
            Console.WriteLine();
            
            break;
        case 2: MostrarBandas();
            Console.WriteLine();
        break;
        case 3:
            Console.WriteLine($"Você escolheu a opção " + opcaoescolhidanumerica);
        break;
        case 4:
            Console.WriteLine($"Você escolheu a opção " + opcaoescolhidanumerica);
        break;
        case -1:
            Console.WriteLine($"Você escolheu a opção " + opcaoescolhidanumerica);
        break;





    }


}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registrar bandas\n");
    Console.WriteLine("Qual banda você deseja resgistra hoje ?");
    string nomedabanda = Console.ReadLine()!;
    Listarbandas.Add(nomedabanda);
    Console.Clear();
    Console.WriteLine($"A banda {nomedabanda} foi registrada com sucesso!!");
    Thread.Sleep( 2000 );
    Console.Clear();
    ExibirLogo();
    Exibirmenus();
}
void MostrarBandas()
{
    Console.Clear();
    for (int i = 0; i < Listarbandas.Count; i++)
    {
        Console.WriteLine(Listarbandas[i]);
    }
    Thread.Sleep(2000);
    Console.Clear();
    Exibirmenus();
}
Exibirmenus();


Console.ReadLine();
//Padrão Camel Case - Letra maiúscula no começo