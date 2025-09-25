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

void Exibirmenus()
{
    
    Console.WriteLine("1. Cadastras Bandas");
    Console.WriteLine("2. Listar Bandas");
    Console.WriteLine("3. Avaliar Bandas");
    Console.WriteLine("4. Avaliação Média das Bandas");
}
Exibirmenus();


Console.ReadLine();
//Padrão Camel Case - Letra maiúscula no começo