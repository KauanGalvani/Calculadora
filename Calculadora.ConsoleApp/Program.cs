string[] historicoDeOperacoes = new string[100];// array / vetor / arranjo
int contadorDeOperacoes = 0;


//desafio, criar um historico de calculos.

//loop de repetição
while (true)
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
    Console.WriteLine("6 - historico");
    Console.WriteLine("S - sair");

    Console.WriteLine();

    Console.WriteLine("Selecione uma opção valida: ");

    string? operacaoSelecionada = Console.ReadLine();
    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {
        return;
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
             Console.WriteLine($"{numeroTabuada} X {i} = {resultadoTabuada}"); 
        }
        Console.ReadLine();
        continue;
    }

    else if (operacaoSelecionada == "6")
    {
        Console.WriteLine("Historico de operações: ");
        Console.WriteLine("---------------------------");

        for (int contador = 0; contador < contadorDeOperacoes; contador++)
        {
            Console.WriteLine(historicoDeOperacoes[contador]);
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
        Console.WriteLine("Dgite um numero valido!");
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

    string textoDaOperacao;

    //decisao do usuario
    switch (operacaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            textoDaOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            Console.WriteLine();
            Console.WriteLine("A soma dos dois numeros resulta em: " + resultado);
            break;
        case "2":
            resultado = primeiroNumero - segundoNumero;
            textoDaOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            Console.WriteLine();
            Console.WriteLine("A subtração dos dois numeros resulta em: " + resultado);       
            break;
            
        case "3":
            resultado = primeiroNumero * segundoNumero;
            textoDaOperacao = $"{primeiroNumero} x {segundoNumero} = {resultado}";
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
            textoDaOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            Console.WriteLine();
            Console.WriteLine("A divisao dos dois numeros resulta em: " + resultado);
            break;
        
        default:
            Console.WriteLine("selecione uma operação valida!");
            Console.ReadLine();
            continue;
            
    }
    
    if (contadorDeOperacoes < historicoDeOperacoes.Length)
    {
        historicoDeOperacoes[contadorDeOperacoes] = textoDaOperacao;
    
        contadorDeOperacoes++;
    }

   

    Console.ReadLine();
}