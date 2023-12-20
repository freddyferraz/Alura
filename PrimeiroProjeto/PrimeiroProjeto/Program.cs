//Screen Sound
using System.Security.AccessControl;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaBandas = new List<string> { "U2", "RBD","Pink Floyd","Bon Jovi"};
Dictionary<string,List<double>> cadastroBandas = new Dictionary<string,List<double>>();
cadastroBandas.Add("U2",new List<double>() {10, 5.5, 8, 7 });
cadastroBandas.Add("RBD", new List<double>() { 10,9, 8, 9 });
cadastroBandas.Add("Pink Floyd", new List<double>() { 9, 6.5, 8, 9 });
cadastroBandas.Add("Bon Jovi", new List<double>() { 9, 6.5, 9, 7 });

void ExibirMensagemDeBoasVindas()
{
    Console.Clear();
      
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{

    ExibirMensagemDeBoasVindas();

    Console.WriteLine(@"
Escolha a opção:
1) Registrar Banda
2) Listar Bandas Cadastradas
3) Avaliar Banda
4) Média de uma banda
0) Sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: 
            RegistrarBanda();
            break; 
        case 2: 
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            CalcularMediaBanda();
            break;
        case 0: Console.WriteLine("Obrigado pela preferência. Aguardo seu retorno.");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();

    ExibirTitulo("Registro de Bandas.");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    cadastroBandas.Add(nomeBanda, new List<double> {1});
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);

    ExibirOpcoesDoMenu();
}


void ExibirBandas()
{
    Console.Clear();

    ExibirTitulo("Lista de Bandas Cadastradas");

    /* for(int i = 0; i < listaBandas.Count; i++)
     {
         Console.WriteLine($"Banda: {listaBandas[i]}");
     }*/

    foreach (string banda in cadastroBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite uma tecla para retornar ao menu anteiror");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
    
}

void ExibirTitulo(string titulo)
{
    int qtdletras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdletras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
    Console.WriteLine("\n");
}

void AvaliarBanda()
{
    /*
     Digite qual a banda.
    Se a banda existir >> Atribuir nota
    Senao, voltar Menu Principal
     */
    Console.Clear();
    ExibirTitulo("Avaliação das Bandas.");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(cadastroBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        cadastroBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

void CalcularMediaBanda()
{
    Console.Clear();
    ExibirTitulo("Média das Bandas.");
    Console.Write("Digite o nome da banda que deseja verificar a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (cadastroBandas.ContainsKey(nomeDaBanda))
    {
        List<double> nota = cadastroBandas[nomeDaBanda];
        
        double mediaBanda = cadastroBandas[nomeDaBanda].Average();

        Console.WriteLine($"\nA banda {nomeDaBanda} obteve uma média de notas no valor: {mediaBanda}");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
