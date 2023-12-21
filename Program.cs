using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Teste Iphone:");
//Cria um objeto da classe iphone
Iphone iphone = new Iphone("55+ 11 111111111","Iphone 12","1111111-1",900);

//Faz o teste da metodo ligar
iphone.Ligar();

//Faz o teste do metodo de instalar
iphone.InstalarAplicativo("Youtube");

//Faz o teste do metodo de receber ligação
iphone.ReceberLigacao();

Console.WriteLine("\nTeste Iphone finalizado\n");
//Fim do teste do Iphone

//Cria um objeto da classe Nokia
Console.WriteLine("Teste Nokia:");

//Faz o teste da metodo ligar
Nokia nokia = new Nokia("55+ 11 22222222", "Nokia X", "2222222-1", 200);

//Faz o teste do metodo de instalar
nokia.Ligar();

//Faz o teste do metodo de instalar
nokia.InstalarAplicativo("Twitter");

//Faz o teste do metodo de receber ligação
nokia.ReceberLigacao();

Console.WriteLine("\nTeste Nokia finalizado\n");
// Fim do teste do Nokia e do programa
