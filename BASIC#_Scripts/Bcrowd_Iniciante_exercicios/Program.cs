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

/*int  vezes = 0, numUsuario;
Console.WriteLine("Digite um número para ver a Tabuada de Multiplicação: ");
numUsuario = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 9; i++)
{
   vezes = numUsuario * i;
   Console.WriteLine($"{numUsuario} x {i} = {vezes}");
}


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

// Multiplo de 3 ou 7:


/*Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 3 == 0 || num % 7 == 0)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("falso");
}
*/


/* string codPeca1 = Console.ReadLine() ?? string.Empty;
string codPeca2 = Console.ReadLine() ?? string.Empty;
string[] dados = codPeca1.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries); //método Split captura múltiplos dados na mesma linha
int codigo = int.Parse(dados[0]);
int quantPeca = int.Parse(dados[1]);
double valor = double.Parse(dados[2]);
string[] dados2 = codPeca2.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
int codigo2 = int.Parse(dados2[0]);
int quantPeca2 = int.Parse(dados2[1]);
double valor2 = double.Parse(dados2[2]);

double totalPeca = (quantPeca * valor) + (quantPeca2 * valor2);
Console.WriteLine($"VALOR A PAGAR: R$ {totalPeca:F2}");*/

/* int A = Convert.ToInt32(Console.ReadLine());
 int B = Convert.ToInt32(Console.ReadLine());
 int C = Convert.ToInt32(Console.ReadLine());
 int maior = (A + B + Math.Abs(A - B)) / 2;
 if(C > maior)
 {
     Console.WriteLine($"{C} eh o maior.");

 }
 else
 {
     Console.WriteLine($"{maior} eh o maior");
 }

*/


/*int totalDias = Convert.ToInt32(Console.ReadLine());

int anos = totalDias  / 365;
int restoDias =  totalDias % 365;
int mes = restoDias / 30;
int dia = restoDias % 30;
Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{mes} mes(es)");
Console.WriteLine($"{dia} dia(s)"); 
*/

// VOLUME DE ESFERA:

/*double raioEsfera = Convert.ToDouble(Console.ReadLine());
double volume = (4.0/3) * 3.14159 * Math.Pow(raioEsfera, 3);

Console.WriteLine($"VOLUME = {volume:F3}"); */


// CALCULO AREA: 

/*
string ABC = Console.ReadLine() ??string.Empty;
string[] valor = ABC.Split(new char[]{ ' ' },StringSplitOptions.RemoveEmptyEntries);
double A = double.Parse(valor[0]);
double B = double.Parse(valor[1]);
double C = double.Parse(valor[2]);


double trianguloRetnglo = A * C / 2;
double areaCirculo = 3.14159 * Math.Pow(C,2);
double trapezio = (A + B) * C/ 2;
double quadrado = Math.Pow(B,2);
double retangulo =  A * B;

Console.WriteLine($"TRIANGULO: {trianguloRetnglo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
Console.WriteLine($"QUADRADO: {quadrado:F3}");
Console.WriteLine($"RETANGULO: {retangulo:F3}");*/

// CONSUMO:
/*
int distancia = Convert.ToInt32(Console.ReadLine());
double combustivelGasto = Convert.ToDouble(Console.ReadLine());
double consumoMedio = distancia / combustivelGasto;
Console.WriteLine($"{consumoMedio:F3} km/l");
*/

// DISTÂNCIA ENTRE DOIS PONTOS:

/*string p1 = Console.ReadLine() ?? string.Empty;
string[] eixos = p1.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double x1 = double.Parse(eixos [0]);
double y1 = double.Parse(eixos [1]);
string p2 = Console.ReadLine() ?? string.Empty;
string[] eixos2 = p2.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double x2 = double.Parse(eixos2 [0]);
double y2 = double.Parse(eixos2 [1]);
double distancia = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1, 2));
Console.WriteLine($"{distancia:F4}");
*/

//DISTÂNCIA:
/*int distancia = Convert.ToInt32(Console.ReadLine());
int tempo = distancia * 2;
Console.WriteLine($"{tempo} minutos");*/

//GASTO DE COMBUSTÍVEL

/*int tempoGasto = Convert.ToInt32(Console.ReadLine());
int velocidadMedia = Convert.ToInt32(Console.ReadLine());
double distancia = tempoGasto * velocidadMedia; 
double gasolina = distancia / 12;
Console.WriteLine($"{gasolina:F3}");*/

//CÉDULAS

 int valor = Convert.ToInt32(Console.ReadLine());
 int[] cedulas  = {100, 50, 20, 10, 5, 2, 1};
 foreach (int nota in cedulas)
{
    if(valor > 0 & valor < 1000000)
    {
      valor = nota / cedulas[0];
      Console.WriteLine($"{valor} nota(s) de R$100,00");
       
    }
    else
    {
        Console.WriteLine("Entrada inválida!");
    }
}

