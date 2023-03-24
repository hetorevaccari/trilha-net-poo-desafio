using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "11111-1111", modelo: "Nokia 1", imei: "333333333", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.NovoNumero("99999-9999");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "22222-2222", modelo: "IPhone 1", imei: "444444444", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.NovoNumero("88888-8888");

Console.WriteLine("");