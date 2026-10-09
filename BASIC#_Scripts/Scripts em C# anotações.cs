// Ask for the user's name
Console.WriteLine("Qual seu nome? ");
string name = Console.ReadLine();


 // Ask for the user's age
 Console.WriteLine("Qual sua idade? ");
 string age = Console.ReadLine();
 

 // Display a personalized message that includes both pieces of information
 
Console.WriteLine($"Olá,{name}! Você tem {age} anos.");


//classe System.Math

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

//string name = "Bob";
int number = 3;
double temperature = 34.4;
Console.Write($"Hello, {name}! You have {number} messages in your inbox. The temperature is {temperature} celsius.");
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\"...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage}: 
    c:\Exercise\{projectName}\ru-RU\data.txt");
Console.Write("Enter your age: ");
string? ageInput = Console.ReadLine();
int age = int.Parse(ageInput ?? throw new InvalidOperationException("Age input is required."));
int nextYear = age + 1;
Console.WriteLine($"Next year you'll be {nextYear}");
decimal first = 10;
decimal second = 2;
decimal result = first / second;
Console.WriteLine(result);  


int valorCompra = 1001;
//int desconto = valorCompra > 1000 ? 100 : 50;   
Console.WriteLine($"desconto: {(valorCompra > 1000 ? 100 : 50)}"); //compactar usando operador ternario

/*Exemplo com entrada do usuario*/
Console.WriteLine("Enter sale amount: ");
string? saleAmount = Console.ReadLine();
int discount = Convert.ToInt32 (saleAmount) > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");


//Exemplo com entrada do usuario e compactando a saida

int saleAmnt = 1001;
Console.WriteLine($"Discount: {(saleAmnt > 1000 ? 100 : 50)}");

// teste com operador ternario e WHILE com entrada do usuario de apenas duas opções (S/N)
Console.WriteLine("Deseja Continuar? (S/N)");
string? continueChoice = (Console.ReadLine() ?? "").Trim().ToUpper();
while (continueChoice != "S" && continueChoice != "N")
{
    Console.WriteLine("Opção inválida. Por favor, digite S para Sim ou N para Não.");
    continueChoice = (Console.ReadLine() ?? "").Trim().ToUpper();
}
Console.WriteLine($"Você escolheu {(continueChoice == "S" ? "Continuar" : "Sair")}");

//Exemplo com operador ternario e Random para simular um lançamento de moeda
Random  CoinFlip = new Random();
int flip = CoinFlip.Next(0,2);
Console.WriteLine ((flip == 0) ? "Heads" : "Tails");

// LOOP FOR
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

// LOOP WHILE
int health = 3;
while(health > 0)
{
    Console.WriteLine($"Player is alive. Health: {health}");
    health--;
}

// LOOP DO-WHILE
int tentativas = 0;
do
{
    tentativas++;
    Console.WriteLine($"tentativa: {tentativas}");
}
while (tentativas < 3);

//BREAK
for (int contador = 0; contador < 10; contador++)
{
    if (contador == 5)
    {
       
        break;
    }
    Console.WriteLine(contador);
}
 Console.WriteLine("Break loop");

 //CONTINUE
for (int contador = 0; contador < 10; contador++)
{
    if (contador == 3)
    {
        continue;
    }
    Console.WriteLine(contador);
    
}

// BREAK COM WHILE
while (true)
{
    Console.WriteLine("Digite 'sair' para encerrar o loop.");
    string? userInput = Console.ReadLine();

    if(userInput?.ToLower() == "sair")
    {
        break;
    }
    Console.WriteLine($"Você digitou: {userInput}");
}
Console.WriteLine("Bye Bye!");

//CONTINUE COM WHILE
 int contador2 = 0;
 while (contador2 < 5)
{
    contador2++; // CRUCIAL:Incrementa o contador antes da verificação
    if (contador2 == 3)
    {
        Console.WriteLine($"Pulando o número {contador2}.");
        continue;
    }
    Console.WriteLine($"Itens processados com sucesso {contador2}.");
}
Console.WriteLine("Contagem finalizada!");

// Matriz
string[] colors = {"red", "green", "blue"}; // matriz com três cadeias de caracteres

int[] scores = new int[4]; // matriz que pode conter quatro inteiros

// acessando itens numa matriz por índice

string[] colors = {"red", "green", "blue"};
Console.WriteLine(colors[0]);
Console.WriteLine(colors[2]);
 // exemplo array
 string[] DiasSemana = {"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"};
foreach (string dia in DiasSemana)
{
    if (dia.Contains("feira"))
    {
        Console.WriteLine(dia);
    }
    else{ Console.WriteLine(dia + "\tFim de semana");}

        
}


