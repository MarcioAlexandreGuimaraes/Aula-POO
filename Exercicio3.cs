int notaum, notadois, notatres, resultado;
Console.WriteLine("Digite a primeira nota:");
notaum= int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
notadois= int.Parse(Console.ReadLine());;

Console.WriteLine("Digite a terceira nota:");
notatres = int.Parse(Console.ReadLine());

resultado = (notaum * 2 + notadois * 3 + notatres * 5) / 2;

Console.Write(resultado);
