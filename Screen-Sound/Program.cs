// Screen Sound
string MensagemDeVindas = "Boas vindas ao Screen Sound!!";
//List<string> Listarbandas = new List<string> {"Oficina G3", "Resgate" };
Dictionary<string, List<int>> Listarbandas = new Dictionary<string, List<int>>();
// Para adicionar bandas é colocar Listarbandas.Add
Listarbandas.Add("Oficina G3", new List<int> { 10, 8, 7, 6 });
Listarbandas.Add("Banda Som e Louvor", new List<int> { 2, 8, 6 });

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
    Console.WriteLine("\n1. Cadastrar Bandas");
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
        case 3: AvaliarBandas();
            Console.WriteLine();
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
    Exibirastericos("Registrar bandas");
    Console.WriteLine("Qual banda você deseja resgistra hoje ?");
    string nomedabanda = Console.ReadLine()!;
    Listarbandas.Add(nomedabanda, new List<int>()); // Metódo dicionário
    Console.Clear();
    Console.WriteLine($"A banda {nomedabanda} foi registrada com sucesso!!");
    Thread.Sleep( 4000 );// Alterado o tempo de 2s para 4s
    Console.Clear();
    ExibirLogo();
    Exibirmenus();
}
void MostrarBandas() // função adicionada por conta própria sem auxilio de aula
{
    Console.Clear(); //ideia reutilizada da aula anterior  kkkk limpar o console antes de começar uma nova ação
    Exibirastericos("Todas as bandas");
    foreach (string nomedabanda in Listarbandas.Keys) //adicione o .Keys para mostrar só os valores das chaves novo metódo de dicionário
    {
        Console.WriteLine(nomedabanda);
    }
   // for (int i = 0; i < Listarbandas.Count; i++) // loop for para contar a lista por inteiro e exibir ela após isso
  //  {
  //      Console.WriteLine($"{i + 1}: {Listarbandas[i]}");// Mais uma descoberta solo kkkk enumeration list
  //      //Console.WriteLine(Listarbandas[i]);
  //  }
    Thread.Sleep(2000);// espera dois milisegundos
    Console.ReadKey();// Lê um botão como entrada, para fazer a próxima execução do código
    Console.Clear();// limpa console
    Exibirmenus();// chama os menus
}
Exibirmenus();

void AvaliarBandas()
{
    Console.Clear();
    Exibirastericos("Avaliar Bandas");
    Console.WriteLine("Digite a banda para avalia-la");
    string nomedabanda = Console.ReadLine();
    // Para criar uma condição que comunique bem com a lista de bandas criadas é necessário usar a função (ContainsKey) para puxar somente as chaves das bandas, para poder procurar dentro da lista criada
    if (Listarbandas.ContainsKey(nomedabanda))
    {
        Console.WriteLine($"A banda {nomedabanda} tem  ");
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"A banda {nomedabanda} não foi encontrado por favor verifique se a banda foi adicionado anteriormente no sistema");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Exibirmenus();
    }
     
}

Console.ReadLine();
//Padrão Camel Case - Letra maiúscula no começo
void Exibirastericos(string titulo)
{
    int quantidadedeletras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadedeletras,'=');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");

}

