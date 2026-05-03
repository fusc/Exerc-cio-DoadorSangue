﻿
Console.WriteLine("Qual a sua idade:");
decimal idadeDoador  = Convert.ToDecimal(Console.ReadLine());

if (idadeDoador >= 18 && idadeDoador <= 67)
{
    Console.WriteLine("Você pode doar sangue.");
}
else
    Console.WriteLine("Você não pode doar sangue.");