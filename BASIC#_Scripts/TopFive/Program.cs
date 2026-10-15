 // Set up the game

Random random = new Random(); /*random.Next(...)irá gerar a pontuação de cada rodada, portanto, random é configurada apenas uma vez, antecipadamente.*/
int roundsPlayed = 10;
List<int> allScores = new List<int>(); /*allScores Começa vazio — você adicionará Add (uma pontuação após cada rodada).*/
Console.WriteLine($"Jogando {roundsPlayed} rodadas...\n");

 // Simulate playing rounds and log every score

for (int round = 1; round <= roundsPlayed; round++)
{
    int score = random.Next(0,101);/*retorna um número inteiro aleatório de 0 até, mas não incluindo, 101— portanto, cada pontuação é de 0 a 100.*/
    allScores.Add(score); /*Acrescenta a nova pontuação ao final da lista, incrementando-a em um a cada iteração do loop.*/
    Console.WriteLine($"Rodada {round}: pontuou {score} pontos");
}
Console.WriteLine($"\nTotal de rodadas: {allScores.Count}"); /*allScores.Count Informa quantas pontuações foram registradas até o momento.*/
 // Build the Top 5 leaderboard array
allScores.Sort(); /*Coloca a lista em ordem crescente.*/
allScores.Reverse();/*inverte essa ordem, de forma que a pontuação mais alta fique em primeiro lugar*/
int[]topScores = new int[5]; /*Declarando um vetor de 5 numeros inteiros */ /*topScores é declarado com new int[5] — sua duração é fixada em cinco vagas para o restante do programa*/
for (int i = 0; i < topScores.Length; i++) /*O loop copia os cinco valores mais altos de allScores para topScores usando  topScores.Length de forma que o loop sempre preencha exatamente cinco espaços, independentemente do número de rodadas jogadas.*/
{
    topScores[i] = allScores[i];
}
 // Print the leaderboard
Console.WriteLine("\n 🏆 Pontuações Top 3! ");
for(int i=0; i < topScores.Length; i++)
{
    Console.WriteLine($"{i + 1,2}. {topScores[i],3} pontos"); /* i + 1 Transforma o índice de base zero em uma classificação familiar de 1º a 5º.*/ 
    /*topScores[i]Lê a pontuação armazenada na posição daquele ranking na matriz.*/
}