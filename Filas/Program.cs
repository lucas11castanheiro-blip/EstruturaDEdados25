using System;
using Filas;

Random random = new Random();

CallCenter center = new CallCenter();

center.Call (1234);
center.Call (5678);
center.Call (5432);
center.Call (1468);
center.Call (1004);
center.Call (7702);
center.Call (6123);
center.Call (5192);
center.Call (6234);
center.Call (8324);
center.Call (0236);
center.Call (6352);
center.Call (8251);

while(center.AreThereCalls()){
    IncomingCall? call = center.Answer("Renzo");
    if (call != null)
    {
        Console.WriteLine($"{call.Id} de {call.ClientId} atendido por {call.Consultant} no dia {call.StartTime:dd/MM/yyyy HH:mm}");
        
        Thread.Sleep(random.Next(1000, 10000));

        center.End(call);

        Console.WriteLine($"Atendimento {call.Id} concluido em {call.EndTime - call.StartTime:hh\\:mm\\:ss}");
        Console.WriteLine("=====================");
    }
}