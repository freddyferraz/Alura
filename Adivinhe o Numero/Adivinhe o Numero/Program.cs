using System.Security.Cryptography;

int numero = -1;
int numeroAleatorio;
int tentativas;
int opcaoJogoNumber;
string opcaoJogo;

void InicioJogo()
{
    tentativas = 0;
    Random randon = new Random();
    {
        numeroAleatorio = randon.Next(0, 101);
    }

    do
    {
        Console.Write("\nDigite o número:");
        string numeroAlfa = Console.ReadLine()!;
        numero = int.Parse(numeroAlfa);
        tentativas++;
        if (numero != numeroAleatorio)
        {
            Console.WriteLine("\nTente Novamente!!");
        }
        else
        {
            Console.WriteLine("\nVocê conseguiu com {0} tentativas.", tentativas);
        }


    } while (numero != numeroAleatorio);
}

do
{
    Console.WriteLine(@"
    Jogo da Adivinhação:
    1) Jogar
    2) Sair");

    opcaoJogo = Console.ReadLine();
    opcaoJogoNumber = int.Parse(opcaoJogo);

    switch (opcaoJogoNumber)
    {

        case 1: InicioJogo(); 
            break;
        case 2:Console.WriteLine("Obrigado por Jogar!");
            break; 
        default:Console.WriteLine("Escolha uma das opções acima.");
            break;
    }

} while (opcaoJogoNumber != 2);

