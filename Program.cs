using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphon
Smartphone nokia = new Nokia("456","x45","11111",64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Smartphone iphone = new Iphone("456","x45","11111",64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Resident evil Village");
