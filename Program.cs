﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "55996891234", modelo: "Modelo 535", imei: "11566111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "5489664522", modelo: "Modelo 477", imei: "699992222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Prime Video");