using DesafioPOO.Models;


Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "123123123", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Smartphone iphone = new Iphone(numero: "321321", modelo: "Modelo 2", imei: "321321321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");