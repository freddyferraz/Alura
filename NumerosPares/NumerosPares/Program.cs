List<int> listaInteiros = new List<int>();
int tamanhoLista = 0;

void UsaFor()
{
    for (int i = 0; i < listaInteiros.Count; i++)
    {
        int modulo = listaInteiros[i] % 2;
        if (modulo == 0)
        {
            Console.WriteLine("O número {0} é par", listaInteiros[i]);
        }
    }
    
    MenuPrincipal();
}

void PreencherLista()
{
    Console.Write("Qual o tamanho da lista?");
    string tamanho = Console.ReadLine()!;
    tamanhoLista = int.Parse(tamanho);

    for (int i = 0;i < tamanhoLista; i++)
    {
        Console.Write("\nInforme o {0}º número da lista: ", i + 1);
        string aux = Console.ReadLine()!;
        listaInteiros.Add(int.Parse(aux));
    }
    MenuPrincipal();
}

void UsaForEach()
{
    foreach(int i in listaInteiros)
    {
        int modulo = i % 2;
        if (modulo == 0)
        {
            Console.WriteLine("O número {0} é par",i);
        }
    }
    
    MenuPrincipal();
}

void MenuPrincipal()
{
    
    Console.WriteLine(@"Esolha a Opção:
1) Preencher a Lista
2) Exibir Numeros Pares com FOR
3) Exibir Números Pares com FOREACH
4) Sair");
    String sOpcao = Console.ReadLine()!;
    int nOpcao = int.Parse(sOpcao);

    switch(nOpcao)
    {
        case 1:
            PreencherLista();
            break;
        case 2:
            UsaFor();
            break;
        case 3:
            UsaForEach();
            break; 
        case 4:
            Console.WriteLine("Obrigado por usar o programa");
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
}

MenuPrincipal();

