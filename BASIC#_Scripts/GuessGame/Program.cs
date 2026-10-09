// Set up the game

Random random = new();
int numeroSecreto = random.Next(1, 21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;
Console.WriteLine("Estou pensando em um número de 1 a 20.");
Console.WriteLine($"Você tem {maxGuesses} tentativas. Boa sorte!");

 // Ask the player to guess
 while (guessCount < maxGuesses)
{
    guessCount++;
    Console.Write($"\nTentativa #{guessCount}: ");

int guess = Convert.ToInt32(Console.ReadLine());

// Check the guess and give feedback
if ( guess == numeroSecreto)
{
    Console.WriteLine($"Parabéns! Você acertou em {guessCount} tentativas.");
    hasWon = true;
    break;
}
else if (guess < numeroSecreto)
{
    Console.WriteLine("Muito baixo.");
}
else
{
    Console.WriteLine("Muito alto.");
}

 }
 // Announce the result

 if (!hasWon)
{
    Console.WriteLine($"\nAcabaram suas tentativas. O numero era {numeroSecreto}.");
}