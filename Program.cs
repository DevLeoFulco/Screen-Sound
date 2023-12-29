using System.Globalization;

String mensagemDeBoasVindas = "SEJA BEM VINDO AO SCREEN SOUND!";

List<String> listaDeBandas = new List<string>{"Weslley Safadão", "Mari Fernandes", "Bon Jovi"};




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
    Console.WriteLine(mensagemDeBoasVindas);
    
}

void ExibirOpcoesDoMenu()
{   
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma nova banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir avaliação media de uma banda");
    Console.Write("\n Digite sua opção:");
    
    String opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);
    switch(opcaoEscolhida)
    {
        case 1 : RegistrarBandas();
        
        break;
        case 2: mostrarBandasRegistrada();
        
        break;
        case 3:
        Console.WriteLine("");
        break;
        case 4:
        Console.WriteLine("");
        break;
        default:Console.WriteLine("OPÇÂO INVÁLIDA!");
        break;
    }

}
void RegistrarBandas ()
{
    Console.Clear();
    Console.WriteLine("**************************");
    Console.WriteLine("REGISTRO DE BANDAS");
    Console.WriteLine("**************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($" {nomeDaBanda} foi registrada com SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void mostrarBandasRegistrada()
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("LISTA DE BANDAS REGISTRADAS");
    Console.WriteLine("***********************************\n");

    for (int i= 0; i<listaDeBandas.Count; i++)
    {
        Console.WriteLine($"BANDA - {listaDeBandas[i]}");
    }
    Console.WriteLine("\nDeseja REGISTRAR uma nova banda ? digite S para Registrar ou N para voltar ao MENU PRINCIPAL");
    string digitouSim = Console.ReadLine();
    if (digitouSim == "S")
    {
        RegistrarBandas();
    }else if (digitouSim == "N") 
    {
        ExibirOpcoesDoMenu();
    }
    
    
    
    ExibirOpcoesDoMenu();

}

ExibirLogo();
ExibirOpcoesDoMenu();