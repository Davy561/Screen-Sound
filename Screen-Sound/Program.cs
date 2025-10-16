// Screen Sound
string MensagemDeVindas = "Boas vindas ao Screen Sound!!";
void ExibirMensagemDeBoasVindas()
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
ExibirMensagemDeBoasVindas();

void Exibirmenus() // Isso é um chamada de função
{

    Console.WriteLine("\n1. Cadastras Bandas");
    Console.WriteLine("2. Listar Bandas");
    Console.WriteLine("3. Avaliar Bandas");
    Console.WriteLine("4. Avaliação Média das Bandas");

    Console.Write("\nDigite -1 para sair:");
    string opcaoescolhida = Console.ReadLine()!; // Obtém a opção escolhida pelo usuário
    int opcaoescolhidanumerica = int.Parse(opcaoescolhida); // Converte o tipo do valor de string para int
    switch (opcaoescolhidanumerica) // Isso serve como estrutura de condições if e else, só que de uma forma mais simples e menos complexa
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção" + opcaoescolhidanumerica);
        break;
        case 2:
            Console.WriteLine($"Você escolheu a opção" + opcaoescolhidanumerica);
        break;
        case 3:
            Console.WriteLine($"Você escolheu a opção" + opcaoescolhidanumerica);
        break;
        case 4:
            Console.WriteLine($"Você escolheu a opção" + opcaoescolhidanumerica);
        break;
        case -1:
            Console.WriteLine($"Você escolheu a opção" + opcaoescolhidanumerica);
        break;





    }


}
Exibirmenus();


Console.ReadLine();
//Padrão Camel Case - Letra maiúscula no começo