using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "111111111", modelo: "Nokia v1", imei: "7165asdsd", memoria: 8);
Console.WriteLine("Teste Nokia");
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");
n1.ReceberLigacao();

Console.WriteLine("----------------");

Iphone ip1 = new Iphone(numero: "222222222", modelo: "Iphone v1", imei: "2763askg", memoria: 16);
Console.WriteLine("Teste Iphone");
ip1.Ligar();
ip1.InstalarAplicativo("Instagram");
ip1.ReceberLigacao();

