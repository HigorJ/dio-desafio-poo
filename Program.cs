using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Nokia n = new Nokia("Nokia", "3310", "1234", 124);
n.Ligar();
n.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Iphone i = new Iphone("Iphone", "2G", "1235", 64);
i.ReceberLigacao();
i.InstalarAplicativo("Zap");
