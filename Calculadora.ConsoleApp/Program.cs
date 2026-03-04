bool continuar = true;

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
    Console.WriteLine("S - sair");

    Console.WriteLine();

    Console.WriteLine("Selecione uma opção valida: ");

    string operacaoSelecionada = Console.ReadLine();
    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {
        continuar = false;
        continue;
    }

    //leituras dos numeros digitados pelo usuario
    Console.Write("Digite o primeiro numero: ");
    string strprimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo numero: ");
    string strsegundoNumero = Console.ReadLine();

    Console.WriteLine("-----------------------------------");

    Console.WriteLine();

    Console.WriteLine("O primeiro numero digitado foi: " + strprimeiroNumero);
    Console.WriteLine();
    Console.WriteLine("O segundo numero digitado foi: " + strsegundoNumero);

    //conversao de strin para int
    int primeiroNumero = Convert.ToInt32(strprimeiroNumero);
    int segundoNumero = Convert.ToInt32(strsegundoNumero);

    int resultado;

    if (operacaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }

    else if (operacaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }

    else if (operacaoSelecionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }

    else
    {
        if (segundoNumero == 0 || primeiroNumero == 0)
        {
            Console.WriteLine("Erro");
            return;
        }
        resultado = primeiroNumero / segundoNumero;
    }

    Console.WriteLine();

    Console.WriteLine("A soma dos dois numeros resulta em: " + resultado);

    Console.ReadLine();
}


