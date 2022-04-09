double altura, pesoideal;
string sexo2 ;

Console.Write("Digite sua altura: ");
altura = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Sexo M/F: ");
sexo2 = Console.ReadLine()!.ToUpper().Trim(); 

if(sexo2 != "M" && sexo2 != "F" )
{   
    Console.WriteLine("Não pode ser calculado"); 
}

else
{   
    if(sexo2 == "M")
    {   
        pesoideal = altura * 72.7 - 58.0;
    }

    else
    {   
        pesoideal = altura * 62.1 - 44.7;
    }

    Console.WriteLine($"Seu peso ideal é {pesoideal:n2}");
}

