Menu();//chamando o metodo menu

//metodo menu
static void Menu()
{
    Console.Clear();

    Console.WriteLine("para escolher o que quer fazer digite:");
    Console.WriteLine("0 - para sair");
    Console.WriteLine("1 - para soma");
    Console.WriteLine("2 - para subtracao");
    Console.WriteLine("3 - para multiplicacao");
    Console.WriteLine("4- para divisao");
    Console.WriteLine("o que deseja fazer?");
    short escolha = short.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 0: Sair(); break;
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        default: Menu(); break;
    }
}

//metodo sair
static void Sair()
{
    Console.WriteLine("se voce realmente deseja sair digite 0, caso contrario digite 1:");
    short sair = short.Parse(Console.ReadLine());

    if (sair == 1)
        Menu();

    else
        Console.WriteLine("ate logo!");

}

//metodo subtracao
static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("passe o primeiro numero que sera subtraido");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("passe o segundo numero que sera subtraido");
    float number2 = float.Parse(Console.ReadLine());

    if (number1 > number2)
    {
        Console.WriteLine($"o valor da subtracao eh {number1 - number2} subtraido");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"o valor da subtracao eh {number2 - number1}");
        Console.WriteLine("");
    }
    Console.ReadKey();
    Menu();
}

//metodo soma
static void Soma()
{
    Console.Clear();
    Console.WriteLine("Passe um numero para a variavel 1: ");
    float number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"o valor do variavel 1 eh number1 {number1}");
    //separacao
    Console.WriteLine("Passe um numero para a variavel 2: ");
    float number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"o valor do variavel 2 eh {number2}");

    Console.WriteLine($"o valor da soma eh {number1 + number2}");
    Console.WriteLine("");
    Console.ReadKey();
    Menu();
}

//metodo divisao
static void Divisao()
{
    Console.Clear();
    //chamando os parametros
    Console.WriteLine("digite o seu nominador");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("digite o seu denominador");
    float number2 = float.Parse(Console.ReadLine());

    //efetuando os calculos
    Console.WriteLine($"o resultado da divisao eh: {number1 / number2}");
    Console.WriteLine("");
    Console.ReadKey();
    Menu();
}

//metodo multiplicacao
static void Multiplicacao()
{
    Console.Clear();
    //chamando os parametros
    Console.WriteLine("digite o primeiro valor");
    float number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("digite o segundo valor");
    float number2 = float.Parse(Console.ReadLine());

    //efetuando os calculos
    Console.WriteLine($"o resultado da divisao eh: {number1 * number2}");
    Console.WriteLine("");
    Console.ReadKey();
    Menu();
}








