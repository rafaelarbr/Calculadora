int operacao, soma, subtracao, multiplicacao, divisao, A, B;

do
{


 
    do
    {

        Console.WriteLine("Qual operação deseja fazer?");
        Console.WriteLine("1. Soma, 2. Subtração, 3. Multiplicação, 4. Divisão, 5. Sair");
        operacao = Convert.ToInt32(Console.ReadLine());


        if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5)
        {
            Console.WriteLine("Operação inválida");
        }
    } while (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5);

    if (operacao == 5)
    {
        Console.WriteLine("Você saiu.");
        break;
    }

    Console.WriteLine("Qual o primeiro valor da operação?");
    A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qual o segundo valor da operação?");
    B = Convert.ToInt32(Console.ReadLine());

    if (operacao == 1)
    {
        soma = A + B;
        Console.WriteLine("Soma = " + soma);
    }
    else if (operacao == 2)
    {
        subtracao = A - B;
        Console.WriteLine("Subtração = " + subtracao);
    }
    else if (operacao == 3)
    {
        multiplicacao = A * B;
        Console.WriteLine("Multiplicação = " + multiplicacao);
    }
    else if (operacao == 4)
    {
        divisao = A / B;
        Console.WriteLine("Divisão = " + divisao);
    }


} while (operacao != 5);

