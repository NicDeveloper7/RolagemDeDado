    //By NicholasDev

    //Declaração de variável
    int faces;
    //Comando para gerar números aleatórios
    Random prizedraw = new Random();

    Console.WriteLine("----- Rolagem de Dado -----");
    Console.WriteLine();

    Console.WriteLine("Digite a quantidade de faces do dado: ");
    faces = int.Parse(Console.ReadLine()!);

    //Condicional para verificar se o usuário digitou o número de faces corretamente
    if (faces < 0) 
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Digite um número de faces validas: ");
    }
    else 
    {
        //Gerando números aleatórios com a variável que recebeu o valor das faces anteriormente
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        int scroll = prizedraw.Next(1, faces);
        Console.WriteLine("--- Dado rolando... ---");
        Console.WriteLine();

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        //Exibe o número exato de faces
        Console.WriteLine($"Número de faces: {faces}");
        //E aqui exibe o número aleatório
        Console.WriteLine($"Rolagem: {scroll}");
    }