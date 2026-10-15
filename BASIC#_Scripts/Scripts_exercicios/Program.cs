/*MÉTODO MAIS SIMPLES PARA TROCAR DUAS VARIÁVEIS É USAR UMA TERCEIRA VARIÁVEL TEMPORÁRIA:

int num1, num2, temp;
Console.WriteLine("Digite o primeiro numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

//troca de valores
temp = num1;
num1 = num2;
num2 = temp;


Console.Write("\nApós trocar: ");
Console.Write("\nPrimeiro número: " + num1);
Console.Write("\nSegundo número: " + num2);

Console.Read();*/

// MULTIPLICAR 3 NÚMEROS E EXIBIR MENSAGEM SE FOR MULTIPLO DE 5 OU 7:


/*int num1, num2, num3, resulta;

Console.WriteLine("Digite o primeiro valor a ser multiplicado: ");
num1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor a ser muliplicado: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor a ser multiplicado: ");
num3 = Convert.ToInt32(Console.ReadLine());
resulta = num1 * num2 * num3;

Console.Write($"{num1} x {num2} x {num3} = ");
if(resulta %5 == 0 ){

    Console.Write($"{resulta} é multiplo de 5");
}
else if (resulta %7 == 0)
{
    Console.WriteLine($"{resulta} é multiplo de 7");
}
else
{
    Console.Write($"{resulta}");
}*/

//MULTIPLICAR NÚMEROS COM ENTRADA DO USUÁRIO E LAÇO DE REPETIÇÃO:

/* int num1, resulta = 1;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite o {i}º valor a ser multiplicado: ");
    num1 =  Convert.ToInt32(Console.ReadLine());
    resulta *= num1;
}
Console.WriteLine($"o resultado da multiplicação é: {resulta} ");
*/

//TABUADA

/* int  vezes = 0, numUsuario;
Console.WriteLine("Digite um número para ver a Tabuada de Multiplicação: ");
numUsuario = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 9; i++)
{
    vezes = numUsuario * i;
    Console.WriteLine($"{numUsuario} x {i} = {vezes}");
}*/


//calcular média usando laço de repetição "for" e classe "List"

/*List<int> numerosMedia = new List<int>();
   
   int soma = 0;
   Console.WriteLine("Vamos tirar a média de quatro números!");
   
   for (int i = 1; i <= 4; i++)
   {
   Console.WriteLine($"Digite o {i}º número: ");
   int num = Convert.ToInt32(Console.ReadLine());
   numerosMedia.Add(num);
   }
   foreach (int num in numerosMedia)
{
    soma += num;
}
double media = (double)soma / numerosMedia.Count;

//opção de saída 1:
Console.Write("A média dos números: ");
Console.Write(string.Join(", ", numerosMedia));
Console.Write($" é {media}");

/*opção de saída 2: 
Console.Write($"A média dos números: {numerosMedia[0]}, {numerosMedia[1]}, {numerosMedia[2]}, {numerosMedia[3]} é {media}");
   



//IMPRIMIR APENAS NÚMEROS ÍMPARES

/*int impar = 0;
for(impar = 1; impar <= 99; impar++)
{
    if (impar %2 != 0)
    {
        Console.WriteLine($"{impar}");
    }
    else{};
}*/

// Multiplo de 3 ou 7


Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 3 == 0 || num % 7 == 0)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("falso");
}



