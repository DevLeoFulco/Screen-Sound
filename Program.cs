using System.Globalization;
using Microsoft.Win32;

String mensagemDeBoasVindas = "SEJA BEM VINDO AO SCREEN SOUND!";

//List<String> listaDeBandas = new List<string>{"Weslley Safadão", "Mari Fernandes", "Bon Jovi"};

Dictionary<string,List<int>> registroENotaBandas = new Dictionary<string, List<int>>();
registroENotaBandas.Add("AC/DC",new List<int>{8,9,5});
registroENotaBandas.Add("Iron Maden",new List<int>{10,9,7});
registroENotaBandas.Add("The Glorian",new List<int>());


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
        case 3: AvaliarBandaRegistrada();
        
        break;
        case 4: ExibirMediaBanda();
        
        break;
        default:Console.WriteLine("OPÇÂO INVÁLIDA!");
        break;
    }

}
void RegistrarBandas ()
{
    Console.Clear();
    ExibirTituloEmOpcao("REGISTRO DE BANDAS");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    registroENotaBandas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($" {nomeDaBanda} foi registrada com SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void mostrarBandasRegistrada()
{
    Console.Clear();
    ExibirTituloEmOpcao("TODAS AS BANDAS REGISTRADAS");

    // for (int i= 0; i<listaDeBandas.Count; i++)
    // {
    //     Console.WriteLine($"BANDA - {listaDeBandas[i]}");
    // }

    foreach(string banda in registroENotaBandas.Keys)
    {
        Console.WriteLine($"BANDA - {banda}");
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

void AvaliarBandaRegistrada()
    {
        //Preciso que o usuario informe qual banda quer avaliar
        //Se ela existir -> atribuir nota
        //Se não existir perguntar se quer registrar ela como nova

        Console.Clear();
        ExibirTituloEmOpcao("Avaliação de Bandas");
        Console.Write("Digite o nome da Banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (registroENotaBandas.ContainsKey(nomeDaBanda))
        {
                Console.Write($"Qual avaliação a banda {nomeDaBanda} merece? ");
                int nota = int.Parse(Console.ReadLine());
                registroENotaBandas [nomeDaBanda].Add(nota);
                Console.WriteLine($"\nVocê registrou a nota {nota} com SUCESSO para a banda {nomeDaBanda} !");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesDoMenu();
        }else 
        {
            Console.WriteLine($"{nomeDaBanda} não existe na lista atual de bandas! Deseja Registrar? (S) ou (N) ");
            string digitouSim = Console.ReadLine();

            if (digitouSim == "S")
             {
                RegistrarBandas();
            }else if (digitouSim == "N") 
            {
                ExibirOpcoesDoMenu();
            }

        }

    }
void ExibirTituloEmOpcao(String titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTituloEmOpcao("MÉDIA DAS AVALIAÇÕES DAS BANDAS");
    Console.Write("Digite o nome da banda que deseja saber sua média de avaliação: ");
    string bandaMedia = Console.ReadLine()!;

    if (registroENotaBandas.ContainsKey(bandaMedia))
    {
        List<int> notasBanda = registroENotaBandas[bandaMedia];
        Console.WriteLine($"A média da banda {bandaMedia} foi {notasBanda.Average()} !");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }else {
        Console.WriteLine($"A banda {bandaMedia} não foi encontrada ou não existe media de avaliação !");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal !");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}
ExibirLogo();
ExibirOpcoesDoMenu();