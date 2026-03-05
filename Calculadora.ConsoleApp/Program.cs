bool continuar = true;

//desafio, criar um historico de calculos.

//loop de repetição
while (continuar == true)
{
    Console.Clear();

    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Calculadora");
    Console.WriteLine("--------------------------------------");

    //escolha do usuario
    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5 - tabuada");
    Console.WriteLine("S - sair");

    Console.WriteLine();

    Console.WriteLine("Selecione uma opção valida: ");

    string? operacaoSelecionada = Console.ReadLine();
    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {
        continuar = false;
        continue;
    }

    //logica da tabuada
    if (operacaoSelecionada == "5")
    {
        Console.WriteLine("digite o nunmero que deseja gerar a tabuada: ");
        decimal numeroTabuada = Convert.ToDecimal(Console.ReadLine());
        decimal resultadoTabuada;

        for (int i = 0; i <= 10; i++)
        {
             resultadoTabuada = numeroTabuada * i;
             Console.WriteLine(numeroTabuada + " X " + i + " = " + resultadoTabuada); 
        }
        Console.ReadLine();
        continue;
    }

    //leituras dos numeros digitados pelo usuario
    Console.Write("Digite o primeiro numero: ");
    string? strprimeiroNumero = Console.ReadLine();// (?) quando a variavel nn tem um valor definido.

    Console.Write("Digite o segundo numero: ");
    string? strsegundoNumero = Console.ReadLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strprimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strsegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true) 
    {
        Console.WriteLine("Digite um numero valido!");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("-----------------------------------");

    Console.WriteLine();

    Console.WriteLine("O primeiro numero digitado foi: " + strprimeiroNumero);
    Console.WriteLine("O segundo numero digitado foi: " + strsegundoNumero);

    //conversao de strin para decimal
    decimal primeiroNumero = Convert.ToDecimal(strprimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strsegundoNumero);

    decimal resultado;

    //decisao do usuario
    switch (operacaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            Console.WriteLine();
            Console.WriteLine("A soma dos dois numeros resulta em: " + resultado);
            break;
        case "2":
            resultado = primeiroNumero - segundoNumero;
            Console.WriteLine();
            Console.WriteLine("A subtração dos dois numeros resulta em: " + resultado);       
            break;
            
        case "3":
            resultado = primeiroNumero * segundoNumero;
            Console.WriteLine();
            Console.WriteLine("A multiplicação dos dois numeros resulta em: " + resultado);
            break;

        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Erro");
                return;
            }
            resultado = primeiroNumero / segundoNumero;
            Console.WriteLine();
            Console.WriteLine("A divisao dos dois numeros resulta em: " + resultado);
            break;

        default:
            Console.WriteLine("selecione uma operação valida!");
            Console.ReadLine();
            continue;
            
    }
      
    Console.ReadLine();
}
