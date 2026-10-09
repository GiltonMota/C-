string[] DiasSemana = {"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"};
foreach (string dia in DiasSemana)
{
    if (dia.Contains("feira"))
    {
        Console.WriteLine(dia);
    }
    else{ Console.WriteLine(dia + "\tFim de semana");}

        
}
